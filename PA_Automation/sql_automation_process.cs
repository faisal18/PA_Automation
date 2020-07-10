using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Automation
{
    class sql_automation_process
    {

        #region Global Variables
        public static string query;
        public static string path;
        public static string app_data_path;
        public static List<string> list_3 = new List<string>();
        public static List<string> list_5 = new List<string>();
        public static List<string> list_6 = new List<string>();
        public static List<string> list_7 = new List<string>();
        public static List<string> list_8 = new List<string>();
        public static List<string> list_9 = new List<string>();
        public static List<string> list_10 = new List<string>();

        public static List<data_struct_Q1> list_1 = new List<data_struct_Q1>();
        public static List<data_struct_Q2> list_2 = new List<data_struct_Q2>();
        public static List<data_struct_Q4> list_4 = new List<data_struct_Q4>();
        public static List<data_struct_Q4> list_8_Update = new List<data_struct_Q4>();
       

        public static List<result_struct_cancellation> result_cancellation = new List<result_struct_cancellation>();
        public static List<result_struct_update> result_update = new List<result_struct_update>();
        public static List<result_struct_case2> result_case2 = new List<result_struct_case2>();
        public static string file_path = @ConfigurationManager.AppSettings["path"].ToString();
        #endregion



        public static void SQL_Process_Main(string connection, string PBMM)
        {
            try
            {
                //app_data_path = @ConfigurationManager.AppSettings["path"].ToString();
                //file_path = app_data_path;

                if (Populate_Lists(connection, PBMM))
                    if (Process_Lists())
                        if (Generate_Scripts())
                        {
                            Logger.Info("Processes completed");
                        }
          #region Discarded Process    
                //if (SQL_Control(1, PBMM))
                //{

               
                //if (SQL_Control(2, connection))
                //{
                //    Logger.Info("Process run Success for Case 2 and Connection:" + connection);
                //}
                //else
                //{
                //    Logger.Info("Process run FAIL for Case 2 and Connection:" + connection);
                //}


                //if (lics.Count > 2)
                //{
                //    Logger.Info("Sorting and Matching data for Case 3");
                //    Logger.Info("licenses list contains " + lics.Count + " values before sorting");
                //    lics.Distinct().ToList();
                //    lics.Sort();
                //    Logger.Info("licenses list contains " + lics.Count + " values after sorting");
                //    for (int i = 2; i < lics.Count; i++)
                //    {
                //        if (lics[i].ToString() != "Lic" || lics[i].ToString() != "---")
                //        {
                //            for (int j = 0; j < list_1.Count; j++)
                //            {
                //                if (lics[i] == list_1[j].transactiond)
                //                {
                //                    Logger.Info("\n ################ Match Found !\n Transaction:" + list_1[j].transactiond.ToString() + " having RequestID:" + list_1[j].requestid.ToString() + "  ################# \n");
                //                    result_cancellation.Add(new result_struct_cancellation { requestid = list_1[j].requestid, transactiond = list_1[j].transactiond, idpayer = list_1[j].idpayer });
                //                }
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    Logger.Info("The parsed list is empty for Case 2");
                //}


                //if (SQL_Control(2, PBMM))
                //{
                //    Logger.Info("process run success for case 2 and connection:" + connection);
                //}
                //else
                //{
                //    Logger.Info("process run fail for case 2 and connection:" + connection);
                //}
                //if (list_2.Count > 2)
                //{
                //    Logger.Info("Sorting and Matching data for Case 2");
                //    for (int i = 0; i < list_1.Count; i++)
                //    {
                //        for (int j = 0; j < list_2.Count; j++)
                //        {
                //            if (list_1[i].transactiond == list_2[j].requestid)
                //            {
                //                Logger.Info("\n######################### Match Found !\n RequestID:" + list_1[i].transactiond + " ID:" + list_1[i].requestid + "  ############################ \n");
                //                result_case2.Add(new result_struct_case2 { requestid = list_1[i].transactiond, transactionid = list_1[i].requestid });
                //            }
                //        }
                //    }
                //}

                //if (SQL_Control(3, connection))
                //{
                //    Logger.Info("process run success for case 3 and connection:" + connection);
                //}
                //else
                //{
                //    Logger.Info("process run fail for case 3 and connection:" + connection);
                //}


                //if (Pra_authorizationcode.Count > 2)
                //{
                //    Logger.Info("Sorting and Matching data for Case 3");
                //    Logger.Info("PRA_AuthourizationCode list contains " + Pra_authorizationcode.Count + " values before sorting");
                //    Pra_authorizationcode.Distinct().ToList();
                //    Pra_authorizationcode.Sort();
                //    Logger.Info("PRA_AuthourizationCode list contains " + Pra_authorizationcode.Count + " after before sorting");

                //    for (int i = 2; i < Pra_authorizationcode.Count; i++)
                //    {
                //        for (int j = 0; j < list_1.Count; j++)
                //        {
                //            if (Pra_authorizationcode[i].ToString() == list_1[j].transactiond.ToString())
                //            {
                //                Logger.Info(" \n  ###############################  Match Found !\n AuthCode:" + Pra_authorizationcode[i].ToString() + " having RequestID:" + list_1[j].requestid.ToString() + "  ########################## \n");
                //                result_cancellation.Add(new result_struct_cancellation { requestid = list_1[j].requestid, transactiond = list_1[j].transactiond, idpayer = list_1[j].idpayer });
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    Logger.Info("The parsed list is empty for Case 3");
                //}


                //if (SQL_Control(4, connection))
                //{
                //    Logger.Info("Process run Success for Case 4 and Connection:" + connection);
                //}
                //else
                //{
                //    Logger.Info("Process run FAIL for Case 4 and Connection:" + connection);
                //}


                //if (list_4.Count > 2)
                //{
                //    Logger.Info("Sorting and Matching data for Case 4");
                //    for (int i = 2; i < list_4.Count; i++)
                //    {
                //        if (list_4[i].fileid != "fileid" && list_4[i].fileid != "------")
                //        {
                //            for (int j = 0; j < list_1.Count; j++)
                //            {
                //                if (list_4[i].pra_authourizationcode == list_1[j].transactiond)
                //                {
                //                    if (list_4[i].paa_idpayer == list_1[j].idpayer)
                //                    {
                //                        Logger.Info("\n ########################################## Match Found !\n AuthCode:" + list_4[i].pra_authourizationcode.ToString() + " having RequestID:" + list_1[j].requestid.ToString() + "    ########################## \n");
                //                        result_update.Add(new result_struct_update { fileid = list_4[i].fileid, filenmae = list_4[i].filenmae, paa_idpayer = list_4[i].paa_idpayer, pra_authourizationcode = list_4[i].pra_authourizationcode, requestid = list_1[j].requestid });
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    Logger.Info("The parsed list is empty for Case 4");
                //}

                ////Compare result lists for Case 4 by Case 3
                //for (int i = 0; i < result_cancellation.Count; i++)
                //{
                //    for (int j = 0; j < result_update.Count; j++)
                //    {
                //        if (result_update[j].pra_authourizationcode == result_cancellation[i].transactiond)
                //        {
                //            result_update[j].pra_authourizationcode = null;
                //        }
                //    }
                //}
                ////Compare result lists for Case 4 by Case 2

                //for(int i =0;i< result_case2.Count;i++)
                //{
                //    for(int j = 0;j<result_update.Count;j++)
                //    {
                //        if(result_update[j].pra_authourizationcode == result_case2[i].transactionid)
                //        {
                //            result_update[j].pra_authourizationcode = null;
                //        }
                //    }
                //}

                //Logger.Info("Generating Script for Case 2");
                //generate_script(2);
                //Logger.Info("Generating Script for Cancellation");
                //generate_script(3);
                //Logger.Info("Generating Script for Update");
                //generate_script(4);

                //}
                #endregion
            }
            catch (Exception ex)
            {

                Logger.Info("Exception Occured!\n" + ex.Message);
            }
        }

        public static bool Populate_Lists(string connection, string PBMM)
        {
            Logger.Info("Populate lists has been called");
            bool result = false;
            bool for_DHAnArchive = false;
            try
            {
                if (connection.ToLower() == "dhpo")
                {
                    for_DHAnArchive = true;
                }

                if (SQL_Control(1, PBMM))
                {

                    Logger.Info("list 1 has been populated.Number of records in List 1 are " + list_1.Count);
                    result = true;

                    if (SQL_Control(2, PBMM))
                    {
                        Logger.Info("list 2 has been populated.Number of records in List 2 are " + list_2.Count);
                        result = true;
                    }
                    if (SQL_Control(9, PBMM))
                    {
                        Logger.Info("list 9 has been populated.Number of records in List 9 are " + list_9.Count);
                        result = true;
                    }

                    if (SQL_Control(10, PBMM))
                    {
                        Logger.Info("list 10 has been populated.Number of records in List 10 are " + list_10.Count);
                        result = true;
                    }
                   



                    if (for_DHAnArchive == true)
                    {
                        if (SQL_Control(3, "DHPO"))
                            if (SQL_Control(3, "Archive"))
                            {
                                Logger.Info("list 3 has been populated for both DHPO and Archive.Number of records are " + list_3.Count);
                                list_3.Distinct().ToList();
                                list_3.Sort();
                                Logger.Info("list 3 contains " + list_3.Count + " after sorting");
                                result = true;
                            }

                        if (SQL_Control(5, "DHPO"))
                            if (SQL_Control(5, "Archive"))
                            {
                                Logger.Info("list 5 has been populated for both DHPO and Archive.Number of records are " + list_5.Count);
                                list_5.Distinct().ToList();
                                list_5.Sort();
                                Logger.Info("list 5 contains " + list_5.Count + " after sorting");
                                result = true;
                            }

                        if (SQL_Control(6, "DHPO"))
                            if (SQL_Control(6, "Archive"))
                            {
                                Logger.Info("list 6 has been populated for both DHPO and Archive.Number of records are " + list_6.Count);
                                list_6.Distinct().ToList();
                                list_6.Sort();
                                Logger.Info("list 6 contains " + list_6.Count + " after sorting");
                                result = true;
                            }

                        //if (SQL_Control(7, "DHPO"))
                        //    if (SQL_Control(7, "Archive"))
                        //    {
                        //        Logger.Info("list 7 has been populated for both DHPO and Archive.Number of records are " + list_7.Count);
                        //        list_7.Distinct().ToList();
                        //        list_7.Sort();
                        //        Logger.Info("list 7 contains " + list_7.Count + " after sorting");
                        //        result = true;
                        //    }



                        if (SQL_Control(8, "DHPO"))
                            if (SQL_Control(8, "Archive"))
                            {
                                Logger.Info("list 8 has been populated for both DHPO and Archive.Number of records are " + list_8.Count);
                                list_8.Distinct().ToList();
                                list_8.Sort();
                                Logger.Info("list 8 contains " + list_8.Count + " after sorting");
                                result = true;
                            }

                        if (SQL_Control(4, "DHPO"))
                            if (SQL_Control(4, "Archive"))
                            {

                                Logger.Info("list 4 has been populated for both DHPO and Archive.Number of records are " + list_4.Count);
                                list_4.Distinct().ToList();
                              //  list_4.Sort();
                                result = true;
                            }
                    }
                    else
                    {
                        if (SQL_Control(3, connection))
                        {
                            Logger.Info("list 3 has been populated for " + connection + ".Number of records are " + list_3.Count);
                            result = true;
                        }
                       
                        if (SQL_Control(5, connection))
                        {
                            Logger.Info("list 5 has been populated for " + connection + ".Number of records are " + list_5.Count);
                            result = true;
                        }
                        if (SQL_Control(6, connection))
                        {
                            Logger.Info("list 6 has been populated for " + connection + ".Number of records are " + list_6.Count);
                            result = true;
                        }

                        if (SQL_Control(4, connection))
                        {
                            Logger.Info("list 4 has been populated for " + connection + ".Number of records are " + list_4.Count);
                            result = true;
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public static bool Process_Lists()
        {
            bool result = false;
            Logger.Info("Process Lists has been called");

            try
            {
                //PROCESS LIST 2
                if (list_2.Count > 0)
                {
                    Logger.Info("Sorting and Matching data for Case 2");
                    for (int i = 0; i < list_1.Count; i++)
                    {
                        for (int j = 0; j < list_2.Count; j++)
                        {
                            if (list_1[i].transactiond == list_2[j].requestid)
                            {
                                Logger.Info("\n######################### Match Found !\n RequestID:" + list_1[i].transactiond + " ID:" + list_1[i].requestid + "  ############################ \n");
                                result_case2.Add(new result_struct_case2 { requestid = list_1[i].transactiond, transactionid = list_1[i].requestid });
                            }
                        }
                    }
                }

                //PROCESS LIST 3
                if (list_3.Count > 0)
                {
                   // Logger.Info("Sorting and Matching data for Case 3");
                    //Logger.Info("PRA_AuthourizationCode list contains " + list_3.Count + " values before sorting");
                    //list_3.Distinct().ToList();
                    //list_3.Sort();
                    //Logger.Info("PRA_AuthourizationCode list contains " + list_3.Count + " after before sorting");

                    for (int i = 0; i < list_3.Count; i++)
                    {
                        for (int j = 0; j < list_1.Count; j++)
                        {
                            if (list_3[i].ToString() == list_1[j].transactiond.ToString())
                            {
                                Logger.Info(" \n  ###############################  Match Found !\n AuthCode:" + list_3[i].ToString() + " having RequestID:" + list_1[j].requestid.ToString() + "  ########################## \n");
                                result_cancellation.Add(new result_struct_cancellation { requestid = list_1[j].requestid, transactiond = list_1[j].transactiond, idpayer = list_1[j].idpayer });
                            }
                        }
                    }
                }
                else
                {
                    Logger.Info("The parsed list is empty for Case 3");
                }


          

                if(list_5.Count>0)
                {
                    for (int i = 0; i < list_1.Count; i++) 
                    {

                        
                            if (!list_5.Contains(list_1[i].transactiond)) 
                            {
                                

                            automation_process.Create_Query_Cancellation(4, file_path + "_Case_5_DHPO_PR_NOTFound_Transaction_Cancellation.sql", list_1[i].transactiond, list_1[i].requestid);

                        }
                        else
                        {

                        }

                    }
                }
                else
                {
                    Logger.Info("The parsed list is empty for Case 5");
                }

                if (list_6.Count>0)
                {
                    for (int i = 0; i < list_1.Count; i++)
                    {
                        
                            if (!list_6.Contains(list_1[i].transactiond))
                            {
                           
                            automation_process.Create_Query_Cancellation(4, file_path + "_Case_6_DHPO_Archive_PA_NOTFound_Transaction_Cancellation.sql", list_1[i].transactiond, list_1[i].requestid);
                        }
                        else
                        {
                     //       automation_process.Create_Query_Update(4, file_path + "_DHPO_Case6_Update_Query.sql", list_1[i].transactiond, "", "", list_1[i].requestid);

                        }

                    }
                }

                else
                {
                    Logger.Info("The parsed list is empty for Case 6");
                }

                /*
                 /// check check check CASE 7
                 */
                #region case 7

               
                if (list_7.Count > 0)
                {
                    for (int i = 0; i < list_1.Count; i++)
                    {

                        if (!list_7.Contains(list_1[i].transactiond))
                        {
                           
                            automation_process.Create_Query_Cancellation(4, file_path + "_Case_7_DHPO_Archive_PA_NOTFound_Transaction_Cancellation.sql", list_1[i].transactiond, list_1[i].requestid);
                            
                        }
                        else
                        {
                            Logger.Info("The parsed list is empty for Case 7");

                           
                        }

                    }
                }

                else
                {
                    Logger.Info("The parsed list is empty for Case 7");
                }

                #endregion


                #region case 8


                if (list_8_Update.Count > 0)
                {
                    for (int i = 0; i < list_1.Count; i++)
                    {

                        data_struct_Q4 currentStruct = list_8_Update.Find(x => x.pra_authourizationcode == list_1[i].transactiond);
                        if (currentStruct == null)
                        {
                            //state_id = 11 update
                            //string query = "declare @Transid varchar(max) \n" +
                            //"set @Transid = '" + result_cancellation[i].transactiond + "' \n" +
                            //" \n" +
                            //"update top(1) AUTHORIZATION_TRANSACTION \n" +
                            //"set state_id = 6 \n" +
                            //"where request_id = @Transid \n" +
                            //"and state_id = 2 \n" +
                            //"and id = '" + result_cancellation[i].requestid + "' \n" +
                            //"\nGo \n\n";
                            automation_process.Create_Query_Cancellation(4, file_path + "_Case_8_DHPO_Archive_PA_NOTFound_Transaction_Cancellation.sql", list_1[i].transactiond, list_1[i].requestid);

                        }
                        else
                        {

                         //   Logger.Info("The parsed list is empty for Case 8");

                            //if (SQL_Control(4, "DHPO"))
                            //{
                            //    if (SQL_Control(4, "Archive"))
                            //    {

                            //        Logger.Info("list 4 has been populated for both DHPO and Archive.Number of records are " + list_4.Count);
                            //        list_4.Distinct().ToList();
                            //        list_4.Sort();
                            //        result = true;
                            //    }
                            //}
                            automation_process.Create_Query_Update(4, file_path + "_DHPO_Case8_Update_Query.sql", list_1[i].transactiond, currentStruct.fileid, currentStruct.filenmae, list_1[i].requestid);


                        }

                    }
                }

                else
                {
                    Logger.Info("The parsed list is empty for Case 8");
                }

                #endregion





                //PROCESS LIST 4
                if (list_4.Count > 0)
                {
                    Logger.Info("Sorting and Matching data for Case 4");
                    for (int i = 0; i < list_4.Count; i++)
                    {
                        if (list_4[i].fileid != "fileid" && list_4[i].fileid != "------")
                        {
                            for (int j = 0; j < list_1.Count; j++)
                            {
                                if (list_4[i].pra_authourizationcode == list_1[j].transactiond)
                                {
                                    if (list_4[i].paa_idpayer == list_1[j].idpayer || list_4[i].paa_idpayer == getIDPayer(list_1[j].idpayer))
                                    {
                                        Logger.Info("\n ########################################## Match Found !\n AuthCode:" + list_4[i].pra_authourizationcode.ToString() + " having RequestID:" + list_1[j].requestid.ToString() + "    ########################## \n");
                                        result_update.Add(new result_struct_update { fileid = list_4[i].fileid, filenmae = list_4[i].filenmae, paa_idpayer = list_4[i].paa_idpayer, pra_authourizationcode = list_4[i].pra_authourizationcode, requestid = list_1[j].requestid });
                                        // generate_script(4);

                                       automation_process.Create_Query_Update(4, file_path + "_DHPO_Case4_Update_Query.sql", list_1[j].transactiond, list_4[i].fileid, list_4[i].filenmae,list_1[j].requestid);

                                    }
                                }
                            }
                        }
                    }

                    //Compare result lists for Case 4 by Case 3
                    //for (int i = 0; i < result_cancellation.Count; i++)
                    //    {
                    //        for (int j = 0; j < result_update.Count; j++)
                    //        {
                    //            if (result_update[j].pra_authourizationcode == result_cancellation[i].transactiond)
                    //            {
                    //                result_update[j].pra_authourizationcode = null;
                    //            }
                    //        }
                    //    }
                    //Compare result lists for Case 4 by Case 2

                    //for (int i = 0; i < result_case2.Count; i++)
                    //    {
                    //        for (int j = 0; j < result_update.Count; j++)
                    //        {
                    //            if (result_update[j].pra_authourizationcode == result_case2[i].transactionid)
                    //            {
                    //                result_update[j].pra_authourizationcode = null;
                    //            }
                    //        }
                    //    }
                }
                else
                {
                    Logger.Info("The parsed list is empty for Case 4");
                }


                if (list_9.Count > 0)
                {
                    for (int i = 0; i < list_1.Count; i++)
                    {


                        if (list_9.Contains(list_1[i].transactiond))
                        {


                            automation_process.Create_Query_Cancellation(4, file_path + "_Case_9_PBMM_REJECTED_PA_Transaction_Cancellation.sql", list_1[i].transactiond, list_1[i].requestid);

                        }
                        else
                        {

                        }

                    }
                }
                else
                {
                    Logger.Info("The parsed list is empty for Case 9");
                }



                if (list_10.Count > 0)
                {
                    for (int i = 0; i < list_1.Count; i++)
                    {


                        if (list_10.Contains(list_1[i].transactiond))
                        {

                            automation_process.Create_Query_UPdateforAcceptedTransactions(4, file_path + "_Case_10_PBMM_ACCEPTED_PA_Transaction_UPdate.sql", list_1[i].transactiond , list_1[i].requestid);

                            //automation_process.Create_Query_Update(4, file_path + "_Case_10_PBMM_ACCEPTED_PA_Transaction_Cancellation.sql", list_1[i].transactiond, list_4[i].fileid, list_4[i].filenmae, list_1[j].requestid);
                            //automation_process.Create_Query_Cancellation(4, file_path + "_Case_10_PBMM_ACCEPTED_PA_Transaction_Cancellation.sql", list_1[i].transactiond, list_1[i].requestid);

                        }
                        else
                        {

                        }

                    }
                }
                else
                {
                    Logger.Info("The parsed list is empty for Case 10");
                }



                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public static bool Generate_Scripts()
        {
            bool result = false;
            try
            {
                result = generate_script(2);
                result = generate_script(3);
                result = generate_script(4);
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public static bool SQL_Control(int scenario, string connection)
        {
            try
            {
                Logger.Info("SQL Automation Process Started for Scenario: " + scenario + "and Source: " + connection);
                bool result = false;
                app_data_path = @ConfigurationManager.AppSettings["path"].ToString();
                path = app_data_path + "Case_" + scenario + "_" + connection + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                if (fetch_query(scenario))
                {
                    Logger.Info("Query Fetched Successfully for Scenario: " + scenario);
                    if (execute_query(connection, path))
                    {
                        Logger.Info("Script Generated Successfully");
                        if (parse_csv(path, scenario))
                        {
                            Logger.Info("Parsing successful for file: " + path);
                            Logger.Info("SQL Automation Process Completed for Scenario: " + scenario + " and Source: " + connection);
                            result = true;
                        }
                        else
                        {
                            Logger.Info("Failiure Occured while Parsing CSV: " + path);
                        }
                    }
                    else
                    {
                        Logger.Info("Failiure occured while running query script");
                    }
                }
                else
                {
                    Logger.Info("Failiure occured while fetching query for scenario : " + scenario);
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured!\n" + ex.Message);
                return false;
            }
        }

        #region Process Methods

        private static bool fetch_query(int scenario)
        {
            try
            {
                bool result = false;
                Logger.Info("Fetching Queries");

                switch (scenario)
                {
                    /// Getting List of transactions having state_id = 2
                    case 1:
                        query = "\n SET NOCOUNT ON \n USE PBMM \n" +
                                "select   \n" +
                                " -- TOP 200  \n" +

                                "at.id as Request_ID  \n" +
                                ",at.request_id as Transaction_ID  \n" +
                                ",at.created_dt as Transaction_Date  \n" +
                                ",at.state_id as Transaction_State  \n" +
                                ",p.license_no as Provider_license  \n" +
                                ",p.post_office_username as Provider_PO_Username  \n" +
                                ",p.post_office_password as Provider_PO_Password  \n" +
                                ",pyr.license_no as Payer_License  \n" +
                                ",pyr.dubai_license_no as Payer_Dubai_License  \n" +
                                ",pyr.tpa_code as Payer_TPA_Code  \n" +
                                ",pyr.tpa_dubai_code as Payer_TPA_DUBAI_CODE  \n" +
                                ",pyr.dhpo_username as Payer_DHPO_Username  \n" +
                                ",pyr.dhpo_password as Payer_DHPO_Password  \n" +
                                ",pyr.post_office_username as Payer_PO_Username  \n" +
                                ",pyr.post_office_password as Payer_PO_Password  \n" +
                                ",po.prior_auth_file_id  \n" +
                                ",po.prior_auth_file_name  \n" +
                                ",po.prior_auth_downloaded  \n" +
                                ",po.prior_auth_sent  \n" +
                                ",po.prior_auth_updated_dt  \n" +
                                ",PA.ID_Payer \n" +
                                " \n" +
                                "--, *  \n" +
                                " from AUTHORIZATION_TRANSACTION AT with (nolock)  \n" +
                                " INNER JOIN[dbo].[PRIOR_AUTHORIZATION] PA  with (nolock) on  AT.id = PA.ID \n" +
                            //    "\n and pa.result = 'REJECTED'      \n" +
                                "inner join PROVIDER P with (nolock) on AT.provider_id = P.id  \n" +
                                "inner join PAYER PYR with (nolock) on AT.payer_id = PYR.id  \n" +
                                "left join POST_OFFICE_COMM PO with (nolock) on at.id = po.trans_id  \n" +
                                " \n" +
                                "where at.state_id = 2  \n" +
                                "and at.trans_src in (4)  \n" +
                                "-- and pyr.dubai_license_no = 'INS012'  \n" +
                                "-- and at.created_dt between '2016-01-01' and '2017-01-01' \n" +
                                "-- and at.provider_id <> 576   \n" +
                                " -- and at.payer_id <> 7  \n" +
                                 "\n and at.created_dt < GetDate() - 2 \n" +
                                "and at.provider_id in (select id from PROVIDER where provider_type != 1)  \n" +
                                "and at.pcn_code not in ('DUPLICATE','INVALID','TIMEOUT')  \n" +
                                "order by at.created_dt desc \n";
                        result = true;
                        break;
                    case 2: /// Getting List of transactions from case 1 having state_id not equal   to 2
                        query = "\n SET NOCOUNT ON \n USE PBMM  \n" +
                                "declare @datatable table(data nvarchar(200)) \n";

                        foreach (string data in split_listToArray(1))
                        {
                            query += "insert @datatable(data) values " + "('" + data + "')\n";
                        }
                        query += "select  \n" +
                                "at.id \n" +
                                ",at.request_id \n" +
                                ",at.state_id \n" +
                                "from AUTHORIZATION_TRANSACTION AT with (nolock) \n" +
                                "where  \n" +
                                "at.state_id <> 2 \n" +
                                "and at.request_id in (select data from @datatable) \n" +
                                "order by at.request_id ";
                        result = true;
                        break;
                    case 3: /// Getting List of transactions from DHPO and Archive have cancellation available in PriorRequest Table
                        query = "\n SET NOCOUNT ON \n use DHPO  \n" +
                                "  \n" +
                                "declare @datatable table(data nvarchar(200))  \n";
                        foreach (string data in split_listToArray(1))
                        {
                            query += "insert @datatable(data) values " + "('" + data + "')\n";
                        }

                        query += "  \n" +
                                "  \n" +
                                "select   \n" +
                                "pra.creationdate  \n" +
                                ",pra.authorizationcode  \n" +
                                ",pra.idpayer  \n" +
                                ",pra.authorizationtype  \n" +
                                ",*   \n" +
                                "  \n" +
                                "from PriorRequestAuthorizations pra  with (nolock)  \n" +
                                "where pra.authorizationtype = 'cancellation'  \n" +
                                "and pra.authorizationcode IN (select data from @datatable)  \n" +
                                "order by pra.authorizationcode, pra.creationdate \n";
                        //"select   \n" +
                        //"paa.authorizationcode  \n" +
                        //",pra.authorizationcode  \n" +
                        //",paa.creationdate  \n" +
                        //",pra.creationdate  \n" +
                        //",paa.idpayer  \n" +
                        //",pra.idpayer  \n" +
                        //",pra.authorizationtype  \n" +
                        //",*   \n" +
                        //"  \n" +
                        //"from priorauthorizationauthorization  paa with (nolock)   \n" +
                        //"inner join PriorRequestAuthorizations pra  with (nolock) on pra.authorizationcode = paa.authorizationcode  \n" +
                        //"where pra.authorizationtype = 'cancellation'  \n" +
                        //"and paa.authorizationcode IN (select data from @datatable)  \n" +
                        //"order by paa.authorizationcode, paa.creationdate \n";
                        result = true;
                        break;
                    case 4:

                        #region case 4

                            query = "\n SET NOCOUNT ON \n use DHPO  \n" +
                                " \n";
                        //        "declare @datatable table(data nvarchar(200),data2 nvarchar(200)) \n";
                        //foreach (string data in split_listToArray(1))
                        //{
                        //    query += "insert @datatable(data) values " + "('" + data + "')\n";
                        //}

                        //foreach (string data in split_listToArray(2))
                        //{
                        //    query += "insert @datatable(data2) values " + "('" + data + "')\n";
                        //}
                        for (int i = 0; i < list_1.Count; i++)
                        {
                            query += " \n" +
                                " \n" +
                                "select \n" +
                                " \n" +
                                "paa.authorizationcode \n" +
                                ",pra.authorizationcode \n" +
                                ",paa.creationdate \n" +
                                ",pra.creationdate \n" +
                                ",paa.idpayer \n" +
                                ",pra.idpayer \n" +
                                ",pra.authorizationtype \n" +
                                ",pat.[filename] \n" +
                                ",pat.fileid \n" +
                                "--, *  \n" +
                                "from PriorAuthorizationAuthorization paa  with (nolock)  \n" +
                                "inner join PriorAuthorizationTransaction pat with (nolock)  on paa.priorauthorizationID = pat.transactionid \n" +
                                "inner join PriorRequestTransactions prt with (nolock)  on prt.transactionid = paa.priorrequestid \n" +
                                "inner join PriorRequestauthorizations pra  with (nolock) on prt.transactionid = pra.submissionid \n" +
                                "where pra.authorizationtype <> 'cancellation' AND \n";
                        
                            if (i == (list_1.Count - 1))
                            {
                                query += "(paa.authorizationcode = '" + list_1[i].transactiond + "' ) AND ( paa.idpayer = '" + list_1[i].idpayer + "' OR paa.idpayer = '" + getIDPayer(list_1[i].idpayer) + "' )";
                            }
                            else
                            {
                                query += "(paa.authorizationcode = '" + list_1[i].transactiond + "' ) AND ( paa.idpayer = '" + list_1[i].idpayer + "'  OR paa.idpayer = '" + getIDPayer(list_1[i].idpayer) + "' ) \n UNION ALL\n";
                            }
                        }
                        //"(paa.authorizationcode = '' AND paa.idpayer = '') OR"+
                        //"and paa.authorizationcode IN (select data from @datatable) \n" +
                        //"and paa.idpayer IN (select data2 from @datatable) \n" +
                        query += " \n" +
                        "order by paa.authorizationcode \n";
                        result = true;
                        break;
                    #endregion
                    case 5:
                        #region case 5

                        
                        query = "\n SET NOCOUNT ON \n use DHPO  \n" +
                                "  \n" +
                                "declare @datatable table(data nvarchar(200))  \n";
                        foreach (string data in split_listToArray(1))
                        {
                            query += "insert @datatable(data) values " + "('" + data + "')\n";
                        }

                        query += "  \n" +
                                "  \n" +
                                "select   \n" +
                                "authorizationcode,SubmissionID  \n" +
                                "from PriorRequestAuthorizations  with (nolock) \n" +
                                "where authorizationcode in (select data from @datatable)";
                        result = true;
                        break;
                    #endregion

                    case 6:
                        #region case 6
                        query = "\n SET NOCOUNT ON \n use DHPO  \n" +
                                "  \n" +
                                "declare @datatable table(data nvarchar(200))  \n";
                        foreach (string data in split_listToArray(1))
                        {
                            query += "insert @datatable(data) values " + "('" + data + "')\n";
                        }

                        query += "  \n" +
                                "  \n" +
                                "select   \n" +
                                "authorizationcode,PriorAuthorizationID  \n" +
                                "from PriorAuthorizationAuthorization  with (nolock) \n" +
                                "where authorizationcode in (select data from @datatable)";
                        result = true;
                        break;
                    #endregion
                    case 7:
                        #region case 7

                        query = "\n SET NOCOUNT ON  \n use DHPO  \n" +
                            " \n";
                        //        "declare @datatable table(data nvarchar(200),data2 nvarchar(200)) \n";
                        //foreach (string data in split_listToArray(1))
                        //{
                        //    query += "insert @datatable(data) values " + "('" + data + "')\n";
                        //}

                        //foreach (string data in split_listToArray(2))
                        //{
                        //    query += "insert @datatable(data2) values " + "('" + data + "')\n";
                        //}
                        for (int i = 0; i < list_1.Count; i++)
                        {
                            query += " \n" +
                                " \n" +
                                "select \n" +
                               " paa.authorizationcode  \n" +
                                "from PriorAuthorizationAuthorization paa  with (nolock)  \n" +
                               "where  \n";

                            if (i == (list_1.Count - 1))
                            {
                                query += "(paa.authorizationcode = '" + list_1[i].transactiond + "' AND paa.idpayer = '" + list_1[i].idpayer + "')";
                            }
                            else
                            {
                                query += "(paa.authorizationcode = '" + list_1[i].transactiond + "' AND paa.idpayer = '" + list_1[i].idpayer + "') \n UNION ALL\n";
                            }
                        }
                        //"(paa.authorizationcode = '' AND paa.idpayer = '') OR"+
                        //"and paa.authorizationcode IN (select data from @datatable) \n" +
                        //"and paa.idpayer IN (select data2 from @datatable) \n" +
                        query += " \n" +
                        "order by paa.authorizationcode \n";
                        result = true;
                        break;



                    #endregion

                    #region case 8
                    case 8:
                        query = "\n SET NOCOUNT ON \n use DHPO  \n" +
                            " \n";
                        //        "declare @datatable table(data nvarchar(200),data2 nvarchar(200)) \n";
                        //foreach (string data in split_listToArray(1))
                        //{
                        //    query += "insert @datatable(data) values " + "('" + data + "')\n";
                        //}

                        //foreach (string data in split_listToArray(2))
                        //{
                        //    query += "insert @datatable(data2) values " + "('" + data + "')\n";
                        //}
                        for (int i = 0; i < list_1.Count; i++)
                        {
                            query += " \n" +
                                " \n" +
                                "select \n" +
                                " \n" +
                                "paa.authorizationcode \n" +
                                ",pra.authorizationcode \n" +
                                ",paa.creationdate \n" +
                                ",pra.creationdate \n" +
                                ",paa.idpayer \n" +
                                ",pra.idpayer \n" +
                                ",pra.authorizationtype \n" +
                                ",pat.[filename] \n" +
                                ",pat.fileid \n" +
                                "--, *  \n" +
                                "from PriorAuthorizationAuthorization paa  with (nolock)  \n" +
                                "inner join PriorAuthorizationTransaction pat with (nolock)  on paa.priorauthorizationID = pat.transactionid \n" +
                                "inner join PriorRequestTransactions prt with (nolock)  on prt.transactionid = paa.priorrequestid \n" +
                                "inner join PriorRequestauthorizations pra  with (nolock) on prt.transactionid = pra.submissionid \n" +
                                "where pra.authorizationtype <> 'cancellation' AND \n";

                            if (i == (list_1.Count - 1))
                            {
                                query += "(paa.authorizationcode = '" + list_1[i].transactiond + "')";
                            }
                            else
                            {
                                query += "(paa.authorizationcode = '" + list_1[i].transactiond  + "') \n UNION ALL\n";
                            }
                        }
                        //"(paa.authorizationcode = '' AND paa.idpayer = '') OR"+
                        //"and paa.authorizationcode IN (select data from @datatable) \n" +
                        //"and paa.idpayer IN (select data2 from @datatable) \n" +
                        query += " \n" +
                        "order by paa.CreationDate desc \n";
                        result = true;
                        break;





                    #endregion

                    #region Case 9 

                    /*
          THis case checks in PBMM database for authorization existance as STATUS REJECTED    

          */

                    case 9:

                        query = "\n SET NOCOUNT ON \n USE PBMM  \n" +
                               "declare @datatable table(data nvarchar(200)) \n";

                        foreach (string data in split_listToArray(1))
                        {
                            query += "insert @datatable(data) values " + "('" + data + "')\n";
                        }
                        query += "select  \n" +
                             //   "at.id \n" +
                                "at.request_id \n" +
                                ",at.id \n" +
                                "from AUTHORIZATION_TRANSACTION AT with (nolock) \n" +
                                  " INNER JOIN[dbo].[PRIOR_AUTHORIZATION] PA  with (nolock) on  AT.id = PA.ID \n" +
                                "\n and pa.result = 'REJECTED'      \n" +
                                "where  \n" +
                               // "at.state_id <> 2 and \n" +
                                " at.request_id in (select data from @datatable) \n" +
                                "order by at.request_id ";
                        result = true;


                        break;


                    /*
                 THis case checks in PBMM database for authorization existance as STATUS ACCEPTED    

                 */
                    case 10:

                        query = "\n SET NOCOUNT ON \n USE PBMM  \n" +
                            "declare @datatable table(data nvarchar(200)) \n";

                        foreach (string data in split_listToArray(1))
                        {
                            query += "insert @datatable(data) values " + "('" + data + "')\n";
                        }
                        query += "select  \n" +
                                 //   "at.id \n" +
                                 "at.request_id \n" +
                                 ",at.id \n" +
                                 "from AUTHORIZATION_TRANSACTION AT with (nolock) \n" +
                                   " INNER JOIN[dbo].[PRIOR_AUTHORIZATION] PA  with (nolock) on  AT.id = PA.ID \n" +
                                 "\n and pa.result = 'ACCEPTED'      \n" +
                                 "where  \n" +
                                 // "at.state_id <> 2 and \n" +
                                 " at.request_id in (select data from @datatable) \n" +
                                 "order by at.request_id ";
                        result = true;
                        break;

                
          

                        #endregion

                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Info("Exception Occured !\n" + ex.Message);
                return false;
            }
        }

        private static bool execute_query(string connection, string exec_query_file)
        {
            try
            {
                Logger.Info("Executing Query");
                using (StreamWriter sw = File.CreateText(exec_query_file + ".sql"))
                {
                    sw.WriteLine(query);
                }
                Logger.Info("Query Written Successfully for file:" + exec_query_file + ".sql");

                string argument = String.Format("SQLCMD {0} -i \"{1}\" -o \"{2}\" -W -s\",\" -h-1", Connection.run_connection(connection, app_data_path), exec_query_file + ".sql", exec_query_file + ".csv");
                using (StreamWriter sw = File.CreateText(exec_query_file + ".bat"))
                {
                    sw.WriteLine(argument);
                }
                Logger.Info("Query Script Successfully Executed" + exec_query_file + ".sql for Source:" + connection);
                Logger.Info("Query Output Filename:" + exec_query_file + ".csv");

                Process.Start(path + ".bat").WaitForExit();
                Logger.Info("Batch File:" + path + ".bat" + " Successfully Executed");

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured while Executing Query !\n" + ex);
                return false;
            }
        }

        private static bool parse_csv(string file_path, int scenario)
        {
            try
            {
                bool result = true;
                Logger.Info("Parsing CSV File:" + file_path + ".csv" + " for Scenario:" + scenario);
                if (File.Exists(file_path + ".csv"))
                {
                    string[] abc = File.ReadAllLines(file_path + ".csv");
                    if (abc.Length > 0)
                    {
                        using (var fs = File.OpenRead(file_path + ".csv"))
                        using (var reader = new StreamReader(fs))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                //Logger.Info("Parsing line " + line);

                                var values = line.Split(',');
                                if (values.Count() > 1)
                                {
                                    switch (scenario)
                                    {
                                        case 1:
                                            list_1.Add(new data_struct_Q1 { requestid = values[0], transactiond = values[1], idpayer = values[20] });
                                            result = true;
                                            break;
                                     
                                        case 2:
                                            list_2.Add(new data_struct_Q2 { ID = values[0], requestid = values[1], stateid = values[2] });
                                            result = true;
                                            break;
                                        case 3:
                                            if (values[1] != "authorizationcode" && values[1] != "-----------------")
                                            {
                                                list_3.Add(values[1]);
                                            }
                                            result = true;
                                            break;
                                        case 4:
                                            list_4.Add(new data_struct_Q4 { pra_authourizationcode = values[1], paa_idpayer = values[4], filenmae = values[7], fileid = values[8] });
                                            result = true;
                                            break;
                                        case 5:
                                            if (values[0] != "authorizationcode" && values[0] != "-----------------")
                                            {
                                                list_5.Add(values[0]);
                                            }
                                            result = true;
                                            break;
                                        case 6:
                                            if (values[0] != "authorizationcode" && values[0] != "-----------------")
                                            {
                                                list_6.Add(values[0]);
                                            }
                                            result = true;
                                            break;
                                        case 7:
                                            if (values[0] != "authorizationcode" && values[0] != "-----------------")
                                            {
                                                list_7.Add(values[0]);
                                            }
                                            result = true;
                                            break;
                                        case 8:
                                            if (values[0] != "authorizationcode" && values[0] != "-----------------")
                                            {
                                                list_8_Update.Add(new data_struct_Q4 { pra_authourizationcode = values[1], paa_idpayer = values[4], filenmae = values[7], fileid = values[8] });
                                            }
                                            result = true;
                                            break;
                                        case 9:
                                            if (values[0] != "authorizationcode" && values[0] != "-----------------")
                                            {
                                                list_9.Add(values[0]);
                                            }
                                            result = true;
                                            break;
                                        case 10:

                                            if (values[0] != "authorizationcode" && values[0] != "-----------------")
                                            {
                                                list_10.Add(values[0]);
                                            }
                                            result = true;
                                            break;


                                    }
                                }
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Info("Exception Occured While Parsing CSV !" + ex.Message);
                return false;
            }
        }

        private static bool generate_script(int scenario)
        {
            try
            {
                bool result = false;
                switch (scenario)
                {
                    case 2:
                        using (StreamWriter text = new StreamWriter(path + "_Case2_Result.sql"))
                        {
                            for (int i = 0; i < result_case2.Count; i++)
                            {

                                string query = "update top (1) AUTHORIZATION_TRANSACTION \n" +
                                "set state_id = 6 \n" +
                                ",validation_error = 'Automated Update: This transaction set as cancelled due to wrong configuration of provider as integrated/non-integrated ' \n" +
                                "where request_id = '" + result_case2[i].requestid + "' \n" +
                                "and id = '" + result_case2[i].transactionid + "' " +
                                "and state_id = 2" +
                                "\nGo \n" +
                                "--Updating record number:" + i + "\n\n";
                                text.Write(query);

                            }
                        }
                        result = true;
                        break;
                    case 3:
                        using (StreamWriter text = new StreamWriter(path + "_Cancellation.sql"))
                        {
                            for (int i = 0; i < result_cancellation.Count; i++)
                            {
                                string query = "declare @Transid varchar(max) \n" +
                                "set @Transid = '" + result_cancellation[i].transactiond + "' \n" +
                                " \n" +
                                "update top(1) AUTHORIZATION_TRANSACTION \n" +
                                "set state_id = 8 \n" +
                                "where request_id = @Transid \n" +
                                "and state_id = 2 \n" +
                                "and id = '" + result_cancellation[i].requestid + "' \n" +
                                "\nGo \n\n";
                                text.Write(query);
                            }

                        }

                        result = true;
                        break;

                    case 4:
                        using (StreamWriter text = new StreamWriter(path + "_Update.sql"))
                        {

                            for (int i = 0; i < result_update.Count; i++)
                            {
                                if (result_update[i].pra_authourizationcode != null)
                                {

                                    string query = "update top(1) POST_OFFICE_COMM \n" +
                                    "set prior_auth_file_id = '" + result_update[i].fileid + "' ,prior_auth_file_name = '" + result_update[i].filenmae + "' \n" +
                                    "where trans_id =  \n" +
                                    "( \n" +
                                    "	select  at.ID  \n" +
                                    "	from AUTHORIZATION_TRANSACTION at \n" +
                                    "	inner join PRIOR_AUTHORIZATION pa on pa.id = at.id \n" +
                                    "	where request_id = '" + result_update[i].pra_authourizationcode + "' \n" +
                                    "	and pa.ID_payer = '" + result_update[i].paa_idpayer + "' \n" +
                                    ") \n" +
                                    " \n" +
                                    "\nGO \n\n" +

                                    "declare @Transid varchar(max) \n" +
                                    "set @Transid = '" + result_update[i].pra_authourizationcode + "' \n" +
                                    " \n" +
                                    "update top(1) AUTHORIZATION_TRANSACTION \n" +
                                    "set state_id = 3 \n" +
                                    "where request_id = @Transid \n" +
                                    "and state_id = 2 \n" +
                                    "and id = '" + result_update[i].requestid + "' \n" +
                                    "\nGo \n\n";
                                    text.Write(query);
                                }
                            }
                        }
                        result = true;
                        break;
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured!\n" + ex.Message);
                return false;
            }
        }

        public static string getIDPayer (string idPayer)
        {
            try
            {
                string[] idPayers = idPayer.Split('_');

                if (idPayers.Length > 2)
                {
                    return idPayers[0] + "_" + idPayers[1];
                }
                else
                {
                    return idPayer;
                }


            }
            catch (Exception ex)
            {

                Logger.Error(ex);
                return null;
            }
        }
        #endregion

        #region Custom Controls
        static string split_array(string[] data)
        {
            string concat = null;
            foreach (string s in data)
            {
                concat += "('" + s + "'),";
            }
            return concat.Remove(concat.Length - 1);
        }

        static string[] split_listToArray(int number)
        {
            List<string> list_dummy = new List<string>();
            if (number == 1)
            {
                for (int i = 0; i < list_1.Count; i++)
                {
                    list_dummy.Add(list_1[i].transactiond);
                }

            }
            else if (number == 2)
            {
                for (int i = 0; i < list_1.Count; i++)
                {
                    list_dummy.Add(list_1[i].idpayer);
                }
            }
            return list_dummy.ToArray();
        }

        static bool comparor_list(string text, int index, int scenario)
        {
            bool result = false;

            switch (scenario)
            {
                case 2:
                    for (int i = 0; i < list_1.Count; i++)
                    {
                        if (text == list_1[i].transactiond)
                        {
                            result = true;
                        }
                    }
                    break;
            }
            return result;
        }
        #endregion

        

    }
}
