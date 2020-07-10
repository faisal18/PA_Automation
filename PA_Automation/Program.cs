using System;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace PA_Automation
{
    class Program
    {
        public static string source;
        public static string path;

        static void Main(string[] args)
        {

            //Faisaltest
           
            log4net.Config.XmlConfigurator.Configure();
            //testing.XML_foundtransction();
            // source = ConfigurationManager.AppSettings["source"];
            //automation_process.entrance("haad", @"C:\Users\faisal\Desktop\files\PA_Automation\PA_Automation_HAAD CHECK ORPHANS");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("For DHPO ");
            Console.WriteLine("CASE 1: DB: PBMSWITCH: Get List of Transactions with status 2 from PBM Switch ");
            Console.WriteLine("CASE 2: DB: PBMSWITCH: Take output of Case 1 and Search in PBMM db to find transactions with same IDs but state is NOT EQUAL to 2 ");
            Console.WriteLine("CASE 3: DB: DHPO : Take output of case 1 and search in DHPO and Archive Database - Prior Request for cancellation Status ");
            Console.WriteLine("CASE 4: DB: DHPO : Take output of case 1 and search in DHPO and Archive Database - Prior Authorization with same Transaction ID and ID_Payer ");
            Console.WriteLine("CASE 5: DB: DHPO : Take output of case 1 and search in DHPO and Archive Database - Prior Request exists in DHPO or not  ");
            Console.WriteLine(" DISABLED -- CASE 6: DB: DHPO : Take output of case 1 and search in DHPO and Archive Database - Prior Authorization exists in DHPO or not  ");
            Console.WriteLine(" DISABLED -- CASE 7: DB: DHPO : Take output of case 1 and search in DHPO and Archive Database - Prior Authorization exists with correct ID Payer   ");
            Console.WriteLine("CASE 8: DB: DHPO : Take output of case 1 and search in DHPO and Archive Database - Prior Authorization exists in DHPO or not  ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("For HAAD ");
            Console.WriteLine("CASE 1: DB: PBMSWITCH: Get List of Transactions with status 2 from PBM Switch ");
            Console.WriteLine("CASE 2: DB: PBMSWITCH: Take output of Case 1 and Search in PBMM db to find transactions with same IDs but state is NOT EQUAL to 2 ");
            Console.WriteLine("CASE 3: Search transactions in HAAD using webservice !!!! ");
            Console.WriteLine("---------------------------------------------------------------");
            Logger.Info(" ------------------------------------------------------------------");
            Logger.Info(" ------------------------------------------------------------------");
            Logger.Info(" -------------------- -------------------------- ------------------");
            Logger.Info(" -------------------- -------------------------- ------------------");
            Logger.Info(" Process Starting time: " + DateTime.Now);
            string postOffice = ConfigurationManager.AppSettings["source"];
            postOffice = postOffice.ToUpper();

            if (postOffice == "DHPO")
            {
                Logger.Info(" -------------------- Executing Queries for DHPO ------------------");

                sql_automation_process.SQL_Process_Main("DHPO", "PBMM");
               // sql_automation_process.SQL_Process_Main("Archive", "PBMM");
            }
            else
            if (postOffice == "HAAD")
            {

                HAADProcess();

            }
            else
                if (postOffice == "ALL")
            {
                Logger.Info(" -------------------- Executing Queries for All Post office ------------------");

                Logger.Info(" -------------------- Executing Queries for DHPO ------------------");

                sql_automation_process.SQL_Process_Main("DHPO", "PBMM");
              //  sql_automation_process.SQL_Process_Main("Archive", "PBMM");
                HAADProcess();


            }
            else
            {
                Logger.Info("NO POST OFFICE IS SELECTED IN CONFIG. Kindly update APP.Config");
            }
            //source = "dha";
            //if (build_csv())
            //{
            //    automation_process.entrance("dha", path);

            //}
            //source = "haad";
            //automation_process.entrance("haad", @"C:\Users\faisal\Desktop\single_transaction_PAAutomation");
            //Sample_XML.download_haad_file();
            //Sample_XML.parse_xml();
            string download_path = ConfigurationManager.AppSettings["DownloadLocation"].ToString();
            
           string[] listofDownloadedFIles =   Directory.GetFiles(download_path);
            if (listofDownloadedFIles.Length > 0)
            {
                foreach (string file in listofDownloadedFIles)
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                }
            }
            else
            {

            }


            string AllFIles = ConfigurationManager.AppSettings["path"].ToString();

            string[] AllfilesList = Directory.GetFiles(AllFIles);
            if (AllfilesList.Length > 0)
            {
                foreach (string file in AllfilesList)
                {
                    if (File.Exists(file) && Path.GetFileName(file) != "connections_server.xml")
                    {
                       File.Copy (file, AllFIles + "\\OLDFiles\\" +   Path.GetFileName(file),true);
                        File.Delete(file);
                        
                    }
                }
            }
            else
            {

            }


            Logger.Info(" Process Completed time: " + DateTime.Now);

        }

        public static bool build_csv()
        {
            try
            {
                bool result = false;
                source = ConfigurationManager.AppSettings["source"].ToString();
                source = source.ToUpper();
                string path1 = @ConfigurationManager.AppSettings["path"].ToString();
                path = path1 + "Build_CSV_" + source + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                using (StreamWriter sw = File.CreateText(path + ".sql"))
                {
                    sw.WriteLine(get_query());
                }
                string argument = String.Format("SQLCMD {0} -i \"{1}\" -o \"{2}\" -W -s,-h-1", Connection.run_connection("PBMM", path1), path + ".sql", path + ".csv");
                using (StreamWriter sw = File.CreateText(path + ".bat"))
                {
                    sw.WriteLine(argument);
                }
                Process.Start(path + ".bat").WaitForExit();
                if (File.Exists(path + ".csv"))
                {
                    string[] abc = File.ReadAllLines(path + ".csv");
                    if (abc.Length > 3)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                else
                {
                    result = false;
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Info("Exception occured while building CSV");
                Logger.Error(ex);
                return false;
            }
        }

        public static string get_query()
        {

            string query = "";
            if (source == "DHPO")
            {
                query = "select  \n" +
                        "at.id as Request_ID \n" +
                        ",at.request_id as Transaction_ID \n" +
                        ",at.created_dt as Transaction_Date \n" +
                        ",at.state_id as Transaction_State \n" +
                        ",p.license_no as Provider_license \n" +
                        ",p.post_office_username as Provider_PO_Username \n" +
                        ",p.post_office_password as Provider_PO_Password \n" +
                        ",pyr.license_no as Payer_License \n" +
                        ",pyr.dubai_license_no as Payer_Dubai_License \n" +
                        ",pyr.tpa_code as Payer_TPA_Code \n" +
                        ",pyr.tpa_dubai_code as Payer_TPA_DUBAI_CODE \n" +
                        ",pyr.dhpo_username as Payer_DHPO_Username \n" +
                        ",pyr.dhpo_password as Payer_DHPO_Password \n" +
                        ",pyr.post_office_username as Payer_PO_Username \n" +
                        ",pyr.post_office_password as Payer_PO_Password \n" +
                        ",po.prior_auth_file_id \n" +
                        ",po.prior_auth_file_name \n" +
                        ",po.prior_auth_downloaded \n" +
                        ",po.prior_auth_sent \n" +
                        ",po.prior_auth_updated_dt \n" +
                        ",PA.ID_Payer \n" +
                        "--, * \n" +
                        " from AUTHORIZATION_TRANSACTION AT with (nolock) \n" +
                        " INNER JOIN [PRIOR_AUTHORIZATION] PA  with (nolock) on  AT.id = PA.ID \n" +
                        "inner join PROVIDER P with (nolock) on AT.provider_id = P.id \n" +
                        "inner join PAYER PYR with (nolock) on AT.payer_id = PYR.id \n" +
                        "left join POST_OFFICE_COMM PO with (nolock) on at.id = po.trans_id \n" +
                        "where at.state_id = 2 \n" +
                        "and at.trans_src in (4) \n" +
                        "\n and at.created_dt < GetDate() - 2 \n" +
                        "--and at.created_dt between GETDATE () -90 and GETDATE () \n" +
                        "--and at.provider_id <> 576  \n" +
                        "and at.provider_id in (select id from PROVIDER where provider_type != 1) \n" +
                        "and at.pcn_code not in ('DUPLICATE','INVALID','TIMEOUT') \n" +
                        "order by at.created_dt desc";
            }
            else if (source == "HAAD" || source == "ALL")
            {
                query = "select  \n" +
                        //"  top 250 \n" +
                        "at.id as Request_ID \n" +
                        ",at.request_id as Transaction_ID \n" +
                        ",at.state_id as Transaction_State" +
                        ",at.created_dt as Transaction_Date \n" +
                        ",p.license_no as Provider_license \n" +
                        ",p.post_office_username as Provider_PO_Username \n" +
                        ",p.post_office_password as Provider_PO_Password \n" +
                        ",pyr.license_no as Payer_License \n" +
                        ",pyr.dubai_license_no as Payer_Dubai_License \n" +
                        ",pyr.tpa_code as Payer_TPA_Code \n" +
                        ",pyr.tpa_dubai_code as Payer_TPA_DUBAI_CODE \n" +
                        ",pyr.dhpo_username as Payer_DHPO_Username \n" +
                        ",pyr.dhpo_password as Payer_DHPO_Password \n" +
                        ",pyr.post_office_username as Payer_PO_Username \n" +
                        ",pyr.post_office_password as Payer_PO_Password \n" +
                        ",po.prior_auth_file_id \n" +
                        ",po.prior_auth_file_name \n" +
                        ",po.prior_auth_downloaded \n" +
                        ",po.prior_auth_sent \n" +
                        ",po.prior_auth_updated_dt \n" +
                        ",PA.ID_Payer \n" +
                        "--, * \n" +
                        " from AUTHORIZATION_TRANSACTION AT with (nolock) \n" +
                        " INNER JOIN [PRIOR_AUTHORIZATION] PA  with (nolock) on  AT.id = PA.ID \n" +
                        "inner join PROVIDER P with (nolock) on AT.provider_id = P.id \n" +
                        "inner join PAYER PYR with (nolock) on AT.payer_id = PYR.id \n" +
                        "left join POST_OFFICE_COMM PO with (nolock) on at.id = po.trans_id \n" +
                        "where at.state_id = 2 \n" +
                        "--and request_id = 'PF1304-1120-112005-321532'\n" +
                        "\n and at.created_dt < getdate() - 3 \n" +
                        "and at.trans_src in (3) \n" +
                        "--and at.created_dt between GETDATE () -90 and GETDATE () \n" +
                        "-- and at.provider_id = 330  \n" +
                        "-- and at.payer_id <> 7  \n" +
                        "and at.provider_id in (select id from PROVIDER where provider_type != 1) \n" +
                        "and at.pcn_code not in ('DUPLICATE','INVALID','TIMEOUT') \n" +
                      //  "\n and prior_auth_file_name is not null  \n" +
                        "order by at.created_dt desc" +
                     "";
            }

            return query;
        }

        public static void HAADProcess()
        {
            Logger.Info(" -------------------- Executing Queries for HAAD ------------------");

            string starttime = ConfigurationManager.AppSettings["HAADPeakHourStart"];
            string endtime = ConfigurationManager.AppSettings["HAADPeakHourStop"];

            TimeSpan start = TimeSpan.Parse(starttime);
            TimeSpan end = TimeSpan.Parse(endtime); //  new TimeSpan(06, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                Logger.Info("Current Time " + now);
                Logger.Info("HAAD Peaks Hours Check -- Passes ");

                if (build_csv())
                {
                    automation_process.entrance("HAAD", path);
                }
                else
                {
                    Logger.Info("Error Occured while procesesing for HAAD");
                }
            }
            else
            {
                Logger.Info("Current Time " + now);
                Logger.Info("HAAD Peaks Hours Check -- Fails (TIme should between Midnight to 6:00 AM )");

            }
        }

    }
}
