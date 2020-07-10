using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.IO.Compression;
using Ionic.Zip;
using System.Configuration;
using System.Linq;

namespace PA_Automation
{
    class automation_process
    {
        #region Global Variables
        public static List<parse_CSV> CSV_list = new List<parse_CSV>();
        public static List<result_update> Update_query_list = new List<result_update>();
        public static List<result_cancellation> Cancellation_query_list = new List<result_cancellation>();
        public static List<result_struct_case2> result_case2 = new List<result_struct_case2>();
        public static List<data_struct_Q2> list_2_Haad = new List<data_struct_Q2>();
        public static List<string> list_9_Haad = new List<string>();
        public static List<string> list_10_Haad = new List<string>();


        public static string foundtransactions;
        public static string errorrmessage;
        public static int search_result;

        public static string d_filename;
        public static byte[] d_file;
        public static int download_result;
        public static string file_content;
        public static string d_errormessage;
        public static string guid_id;
        public static string file_path;
        public static bool is_cancellation;

        #endregion

        #region Custom Controls

        public static bool zip_control2(string filecontent, string filename, byte[] byte_file)
        {
            try
            {
                bool result = false;
                string zip_path = @"C:\tmp\" + Path.GetFileName(filename);
                System.IO.File.WriteAllBytes(zip_path, byte_file);
                string extract_path = zip_path + "_" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
                using (var zip = ZipFile.Read(zip_path))
                {
                    zip.ExtractAll(extract_path, ExtractExistingFileAction.OverwriteSilently);
                    zip.Dispose();
                }

                string[] filearray = Directory.GetFiles(extract_path);
                string new_path = "";
                foreach (string s in filearray)
                {
                    new_path = "C:\\tmp\\" + Path.GetFileName(s);
                    System.IO.File.Copy(s, "C:\\tmp\\" + Path.GetFileName(s));
                }

                using (StreamReader read = new StreamReader(new_path))
                {
                    StringBuilder sb = new StringBuilder();
                    string text;
                    while ((text = read.ReadLine()) != null)
                    {
                        sb.Append(text);
                    }
                    file_content = sb.ToString();
                    result = true;
                }
                File.Delete(new_path);
                File.Delete(zip_path);
                Directory.Delete(extract_path, true);

                return result;
            }
            catch (Exception ex)
            {
                Logger.Info("Exception Occured while extracting zip file !" + ex.Message);
                return false;
            }
        }

        public static MemoryStream GenerateStreamFromString(string value)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(value ?? ""));
        }

        public static List<string> check_foundtransaction(string transactions, string transactionid)
        {
            List<string> found_transaction_id = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            Logger.Info("Processing found transactions");
            xdoc.LoadXml(transactions);
            XmlNodeList xml_list = xdoc.GetElementsByTagName("File");

            foreach (XmlNode node in xml_list)
            {
                if (node.Attributes["FileID"].Value.Contains(transactionid))
                {
                    Logger.Info("%%%%%%%%%%%%%%%%%%% FOUND IN WHOLE DAY SEARCH %%%%%%%%%%%%%%%%%%%");
                    Logger.Info("Transaction found in whole day process! TransactionID: " + transactionid + " FileID: " + node.Attributes["FileID"].Value);
                    Logger.Info("Further processing will be executed on the above found transaction");
                    found_transaction_id.Add(node.Attributes["FileID"].Value);
                }
            }
            return found_transaction_id;
        }

        #endregion

        public static void entrance(string source, string path)
        {
            file_path = path;
            switch (source)
            {
                case "DHPO":
                    DHA_Control();
                    break;
                case "HAAD":
                    HAAD_Control();
                    break;
            }
        }

        public static bool Parse_CSV()
        {
            try
            {
                Logger.Info("Populating Arraylists :");
                using (var fs = File.OpenRead(file_path + ".csv"))
                using (var reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values.Length > 19)
                        {
                            CSV_list.Add(new parse_CSV
                            {
                                Request_ID = values[0],
                                transaction_id = values[1],
                                date_range = values[3],
                                provider_login = values[5],
                                provider_password = values[6],
                                Payer_DHA_login = values[11],
                                Payer_DHA_password = values[12],
                                Payer_HAAD_login = values[13],
                                Payer_HAAD_password = values[14],
                                ID_Payer = values[20],
                                Payer_HAAD_license = values[7],

                                Provider_license = values[4]

                            });

                        }
                        else if (values.Length == 5)
                        {
                            CSV_list.Add(new parse_CSV
                            {
                                Request_ID = values[0],
                                transaction_id = values[1],
                                date_range = values[2],
                                Payer_HAAD_login = values[3],
                                Payer_HAAD_password = values[4]
                            });

                        }
                    }
                }
                Logger.Info("Arraylists populated :");
                Logger.Info("Number of records inserted " + CSV_list.Count + "");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        #region DHA Processes

        public static void DHA_Control()
        {
            try
            {
                if (Parse_CSV())
                {
                    if (CSV_list.Count > 2)
                    {
                        Logger.Info("Automation process started for DHA Post Office");
                        Logger.Info(" Total Transactions to Process: " + (CSV_list.Count - 2));

                        for (int index = 2; index < CSV_list.Count; index++)
                        {
                            //direction 1 Sent,2 Receive
                            //status 1 new,2 downloaded

                            if (DHA_Validation_Control(index, 1, 32, 1))
                            {
                                Logger.Info(" Currently PRocessing Transactions : " + (index).ToString() + " with TransactionID:   " + CSV_list[index].transaction_id + " and TransactionDate: " + CSV_list[index].date_range);
                                Logger.Info(" -*/-*/-*/-*/-*/ DHPO_Validation_Control(index, 1, 32, 1)   *--*/-*/-*/-*/");
                                Logger.Info(" INDEX Value Checker ::::  " + index);
                                if (DHA_Validation_Control(index, 2, 16, 1) || DHA_Validation_Control(index, 2, 16, 2))


                                {
                                    Logger.Info("SQL File Updated with TransactionID:  " + CSV_list[index].transaction_id + " and FileName:  " + d_filename);
                                    if (!is_cancellation)
                                    {
                                        Logger.Info("Update List populated");
                                        Update_query_list.Add(new result_update
                                        {
                                            fileguid_Sql = guid_id,
                                            fileid_sql = CSV_list[index].transaction_id,
                                            filename_sql = d_filename,
                                            request_sql = CSV_list[index].Request_ID
                                        });
                                    }
                                    else if (is_cancellation)
                                    {
                                        Logger.Info("Cancellation List populated");
                                        Cancellation_query_list.Add(new result_cancellation { transaction_id = CSV_list[index].transaction_id, request_id = CSV_list[index].Request_ID });
                                    }
                                }
                            }

                            if (DHA_Validation_Control(index, 1, 32, 2))
                            {
                                if (DHA_Validation_Control(index, 2, 16, 2))
                                {
                                    Logger.Info("SQL File Updated with TransactionID:  " + CSV_list[index].transaction_id + " and FileName:  " + d_filename);
                                    if (!is_cancellation)
                                    {
                                        Logger.Info("Update List populated");
                                        Update_query_list.Add(new result_update
                                        {
                                            fileguid_Sql = guid_id,
                                            fileid_sql = CSV_list[index].transaction_id,
                                            filename_sql = d_filename,
                                            request_sql = CSV_list[index].Request_ID
                                        });
                                    }
                                    else if (is_cancellation)
                                    {
                                        Logger.Info("Cancellation List populated");
                                        Cancellation_query_list.Add(new result_cancellation { transaction_id = CSV_list[index].transaction_id, request_id = CSV_list[index].Request_ID });
                                    }
                                }
                            }
                        }
                        Logger.Info("Automation Complete :");
                        Logger.Info("Total Transactions:" + (CSV_list.Count - 2));
                        Logger.Info("Update Transactions:" + Update_query_list.Count);
                        Logger.Info("Cancellation Transactions:" + Cancellation_query_list.Count);
                        if ((Update_query_list.Count) > 0)
                        {
                            Create_Query(4);
                        }
                    }
                    else
                    {
                        Logger.Info("No records found in the generated CSV !");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
            }
        }

        public static bool DHA_Validation_Control(int index, int direction, int filetype, int download_status)
        {
            try
            {
                bool result = false;
                if (filetype == 32)
                {
                    Logger.Info("********Validating Condition of Prior Authourization**********");
                    if (DHA_Search_Transaction(index, direction, filetype, download_status))
                    {
                        XmlDocument xdoc = new XmlDocument();
                        xdoc.LoadXml(foundtransactions);
                        XmlNodeList downloaded_files = xdoc.GetElementsByTagName("File");
                        System.Threading.Tasks.Parallel.ForEach(downloaded_files.Cast<XmlNode>(), (XmlNode files) =>
                        // foreach (XmlNode files in downloaded_files)
                        {
                            string guid_id2 = files.Attributes["FileID"].Value;
                            Logger.Info("Downloading Transaction for Prior Request: FileID:" + guid_id2 + "");
                            if (DHA_Download_File(index, guid_id2))
                            {
                                xdoc.Load(GenerateStreamFromString(file_content));
                                string authourization_id2 = xdoc.SelectSingleNode("Prior.Authorization/Authorization/ID").InnerText;
                                string ID_payer2 = xdoc.SelectSingleNode("Prior.Authorization/Authorization/IDPayer").InnerText;
                                if (authourization_id2 == CSV_list[index].transaction_id)
                                {
                                    if (ID_payer2 == CSV_list[index].Request_ID)
                                        Logger.Info("\n######################## Prior Authorization : Transaction Matched with TransactionID:  " + CSV_list[index].transaction_id + "   ############################# \n");
                                    guid_id = guid_id2;
                                    result = true;
                                }
                                else
                                {
                                    Logger.Info("Prior Authorization : TransactionID:" + CSV_list[index].transaction_id + " Not Matched with AuthourizationID:  " + authourization_id2);
                                }
                            }
                        }
                        );
                    }
                }
                else if (filetype == 16)
                {
                    Logger.Info("*********Validating Condition of Prior Request**********");
                    if (DHA_Search_Transaction(index, direction, filetype, download_status))
                    {
                        List<string> CHecker = new List<string>();
                        string pr_auth_type = "";

                        XmlDocument xdoc = new XmlDocument();
                        xdoc.LoadXml(foundtransactions);
                        XmlNodeList downloaded_files = xdoc.GetElementsByTagName("File");
                        System.Threading.Tasks.Parallel.ForEach(downloaded_files.Cast<XmlNode>(), (XmlNode files) =>
                        //foreach (XmlNode files in downloaded_files)
                        {
                            string guid_id2 = files.Attributes["FileID"].Value;
                            Logger.Info("Downloading Transaction for Prior Request: FileID:" + guid_id2 + "");
                            if (DHA_Download_File(index, guid_id2))
                            {
                                xdoc.Load(GenerateStreamFromString(file_content));
                                pr_auth_type = xdoc.SelectSingleNode("Prior.Request/Authorization/Type").InnerText;
                                string authourization_id2 = xdoc.SelectSingleNode("Prior.Request/Authorization/ID").InnerText;
                                if (authourization_id2 == CSV_list[index].transaction_id)
                                {
                                    CHecker.Add(pr_auth_type);
                                }
                                else
                                {
                                    Logger.Info("Prior_Request : TransactionID:" + CSV_list[index].transaction_id +
                                        " Not Matched with AuthourizationID:  " + authourization_id2);
                                }
                            }
                        }
                        );
                        if (CHecker.Count > 0 && !CHecker.Contains("Cancellation"))
                        {
                            Logger.Info("\n#################  Prior Request : Transaction Matched with Auth_type: " + pr_auth_type + "  and with TransactionID:  " + CSV_list[index].transaction_id + "####################### \n");
                            is_cancellation = false;
                            result = true;
                        }
                        else if (CHecker.Count > 0 && CHecker.Contains("Cancellation"))
                        {
                            Logger.Info("\n%%%%%%%%%%%%%%%%%%%%%%%%%  Prior Request Cancellation : Transaction cancellation found for TransactionID: " + CSV_list[index].transaction_id + " %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n");
                            is_cancellation = true;
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

        public static bool DHA_Search_Transaction(int index, int direction, int filetype, int download_status)
        {
            try
            {
                DateTime original = Convert.ToDateTime(CSV_list[index].date_range);
                DateTime end = original.AddMinutes(2);
                DateTime start = original.Add(new TimeSpan(0, -2, 0));
                bool result = false;

                Logger.Info("Searching Transaction");
                dhpo_ValidateTransactions.ValidateTransactionsSoapClient dhpo_ws = new dhpo_ValidateTransactions.ValidateTransactionsSoapClient();

                search_result = dhpo_ws.SearchTransactions(CSV_list[index].Payer_DHA_login, CSV_list[index].Payer_DHA_password, direction, "", "", filetype, download_status, "",
                    start.ToString("yyyy-MM-dd HH:mm"), end.ToString("yyyy-MM-dd HH:mm"), -1, -1, out foundtransactions, out errorrmessage);

                if (search_result == 0 && foundtransactions != "")
                {
                    Logger.Info("\n#################  Found Transactions:" + foundtransactions);
                    result = true;
                }

                else
                {
                    Logger.Info("Transaction Not Found for Payer : login:" + CSV_list[index].Payer_DHA_login + " Password:" + CSV_list[index].Payer_DHA_password +
                        "  with File Type : " + filetype + " and with TransactionID: " + CSV_list[index].transaction_id +
                        "   and Download Status : " + download_status);

                    Logger.Info("WebService returned:" + search_result);
                    Logger.Info("Error Message: " + errorrmessage);
                    result = false;
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        public static bool DHA_Download_File(int index, string fileid)
        {
            try
            {
                bool result = false;
                string d_filename2 = "";
                dhpo_ValidateTransactions.ValidateTransactionsSoapClient dhpo_ws = new dhpo_ValidateTransactions.ValidateTransactionsSoapClient();
                download_result = dhpo_ws.DownloadTransactionFile(CSV_list[index].Payer_DHA_login, CSV_list[index].Payer_DHA_password, fileid
                    , out d_filename2, out d_file, out d_errormessage);

                if (download_result == 0)
                {
                    if (Path.GetExtension(d_filename2).ToString() == ".zip" || Path.GetExtension(d_filename2).ToString() == ".ZIP")
                    {
                        Logger.Info("File is in ZIP format FileID:" + fileid);
                        if (zip_control2((Convert.ToBase64String(d_file)), d_filename2, d_file))
                        {
                            Logger.Info("File Zip extraction was Successfull");
                            d_filename = d_filename2;
                            result = true;
                        }
                        else
                        {
                            Logger.Info("File Zip extraction Failed for FileID:" + fileid);
                        }
                    }
                    else
                    {
                        Logger.Info("File Downloaded Successfully!\nLogin:" + CSV_list[index].Payer_DHA_login + " Password:" +
                            CSV_list[index].Payer_DHA_password + " FileID:" + fileid);

                        file_content = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Convert.ToBase64String(d_file)));
                        d_filename = d_filename2;
                        result = true;
                    }
                }
                else
                {
                    Logger.Info("File Download Fail!\nLogin:" + CSV_list[index].Payer_DHA_login + " Password:" + CSV_list[index].Payer_DHA_password + " FileID:" + fileid);
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        #endregion

        #region HAAD Processes

        public static void HAAD_Control()
        {
            Logger.Info("Haad Control ---");


            try
            {
                if (Parse_CSV())
                {
                    Case2_CheckforDuplicates();
                    #region Webservice Region


                    if (CSV_list.Count > 2)
                    {
                        Logger.Info("Automation process started for HAAD Post Office");
                        Logger.Info(" Total Transactions to Process: " + (CSV_list.Count - 2));



                        for (int index = 2; index < CSV_list.Count; index++)
                        {
                            Logger.Info(" Currently PRocessing Transactions : " + (index).ToString() + " with TransactionID:   " + CSV_list[index].transaction_id + " and TransactionDate: " + CSV_list[index].date_range);
                            if (HAAD_Validation_Control(index, 1, 32, 1))
                            {

                                Logger.Info(" -*/-*/-*/-*/-*/ HAAD_Validation_Control(index, 1, 32, 1)   *--*/-*/-*/-*/");
                                Logger.Info(" INDEX Value Checker ::::  " + index);
                                if (HAAD_Validation_Control(index, 2, 16, 1) || HAAD_Validation_Control(index, 2, 16, 2))
                                {
                                    Logger.Info(" -*/-*/-*/-*/-*/ (HAAD_Validation_Control(index, 2, 16, 1) || HAAD_Validation_Control(index, 2, 16, 2))   *--*/-*/-*/-*/");
                                    Logger.Info("SQL File Updated with TransactionID:  " + CSV_list[index].transaction_id + " and FileName:  " + d_filename);
                                    if (!is_cancellation)
                                    {
                                        Logger.Info("%%%%%%%%%%%%%%%%%%% Update List populated %%%%%%%%%%%%%%%%%%%");
                                        Logger.Info("Update List: FileGuidID: " + guid_id + " FileIdD: " + CSV_list[index].transaction_id + " FileName: " + d_filename + " RequestSQL: " + CSV_list[index].Request_ID);

                                        Create_Query_Update(3, file_path + "_New_Update_Query.sql", CSV_list[index].transaction_id, guid_id, d_filename, CSV_list[index].Request_ID);

                                        Update_query_list.Add(new result_update
                                        {
                                            fileguid_Sql = guid_id,
                                            fileid_sql = CSV_list[index].transaction_id,
                                            filename_sql = d_filename,
                                            request_sql = CSV_list[index].Request_ID
                                        });
                                    }
                                    else if (is_cancellation)
                                    {

                                        Logger.Info("%%%%%%%%%%%%%%%%%%% Cancellation List populated %%%%%%%%%%%%%%%%%%%");
                                        Logger.Info("Cancellation List: TransactionID: " + CSV_list[index].transaction_id + " RequestID: " + CSV_list[index].Request_ID);
                                        Create_Query_Cancellation(3, file_path + "_New_Update_Cancellation.sql", CSV_list[index].transaction_id, CSV_list[index].Request_ID);

                                        Cancellation_query_list.Add(new result_cancellation
                                        {
                                            transaction_id = CSV_list[index].transaction_id,
                                            request_id = CSV_list[index].Request_ID
                                        });
                                    }
                                }
                            }
                            else
                            if (HAAD_Validation_Control(index, 1, 32, 2))
                            {
                                Logger.Info(" INDEX Value Checker ::::  " + index);

                                Logger.Info(" -*/-*/-*/-*/-*/ HAAD_Validation_Control(index, 1, 32, 2)   *--*/-*/-*/-*/");
                                if (HAAD_Validation_Control(index, 2, 16, 1) || HAAD_Validation_Control(index, 2, 16, 2))

                                {
                                    Logger.Info(" -*/-*/-*/-*/-*/ (HAAD_Validation_Control(index, 2, 16, 1) || HAAD_Validation_Control(index, 2, 16, 2))   *--*/-*/-*/-*/");
                                    Logger.Info("SQL File Updated with TransactionID:  " + CSV_list[index].transaction_id + " and FileName:  " + d_filename);
                                    if (!is_cancellation)
                                    {

                                        Logger.Info("%%%%%%%%%%%%%%%%%%% Update List populated %%%%%%%%%%%%%%%%%%%");
                                        Logger.Info("Update List: FileGuidID: " + guid_id + " FileIdD: " + CSV_list[index].transaction_id + " FileName: " + d_filename + " RequestSQL: " + CSV_list[index].Request_ID);
                                        Create_Query_Update(3, file_path + "_New_Update_Query.sql", CSV_list[index].transaction_id, guid_id, d_filename, CSV_list[index].Request_ID);

                                        Update_query_list.Add(new result_update
                                        {
                                            fileguid_Sql = guid_id,
                                            fileid_sql = CSV_list[index].transaction_id,
                                            filename_sql = d_filename,
                                            request_sql = CSV_list[index].Request_ID
                                        });
                                    }
                                    else if (is_cancellation)
                                    {
                                        Logger.Info("%%%%%%%%%%%%%%%%%%% Cancellation List populated %%%%%%%%%%%%%%%%%%%");
                                        Logger.Info("Cancellation List: TransactionID: " + CSV_list[index].transaction_id + " RequestID: " + CSV_list[index].Request_ID);
                                        Create_Query_Cancellation(3, file_path + "_New_Update_Cancellation.sql", CSV_list[index].transaction_id, CSV_list[index].Request_ID);

                                        Cancellation_query_list.Add(new result_cancellation
                                        {
                                            transaction_id = CSV_list[index].transaction_id,
                                            request_id = CSV_list[index].Request_ID
                                        });
                                    }
                                }
                            }
                            else
                            if (HAAD_Validation_Control(index, 2, 16, 1) && is_cancellation)
                            {
                                //   ADDING CODE TO CHECK IF THERE ARE PR AVAILABLE AND CANCELLED OR NOT

                                Logger.Info("  -*/-*/-*/ ADDING CODE TO CHECK IF THERE ARE PR AVAILABLE AND CANCELLED OR NOT -*/-*/-*/");


                                Logger.Info(" INDEX Value Checker ::::  " + index);

                                Logger.Info(" -*/-*/-*/-*/-*/ (HAAD_Validation_Control(index, 2, 16, 1) )   *--*/-*/-*/-*/");
                                //   Logger.Info("SQL File Updated with TransactionID:  " + CSV_list[index].transaction_id + " and FileName:  " + d_filename);
                                if (!is_cancellation)
                                {

                                    //Logger.Info("%%%%%%%%%%%%%%%%%%% Update List populated %%%%%%%%%%%%%%%%%%%");
                                    //Logger.Info("Update List: FileGuidID: " + guid_id + " FileIdD: " + CSV_list[index].transaction_id + " FileName: " + d_filename + " RequestSQL: " + CSV_list[index].Request_ID);
                                    //Create_Query_Update(3, file_path + "_New_Update_Query.sql", CSV_list[index].transaction_id, guid_id, d_filename, CSV_list[index].Request_ID);

                                    //Update_query_list.Add(new result_update
                                    //{
                                    //    fileguid_Sql = guid_id,
                                    //    fileid_sql = CSV_list[index].transaction_id,
                                    //    filename_sql = d_filename,
                                    //    request_sql = CSV_list[index].Request_ID
                                    //});
                                }
                                else if (is_cancellation)
                                {
                                    Logger.Info("%%%%%%%%%%%%%%%%%%% Cancellation List populated %%%%%%%%%%%%%%%%%%%");
                                    Logger.Info("Cancellation List: TransactionID: " + CSV_list[index].transaction_id + " RequestID: " + CSV_list[index].Request_ID);
                                    Create_Query_Cancellation(3, file_path + "_New_Update_Cancellation.sql", CSV_list[index].transaction_id, CSV_list[index].Request_ID);

                                    Cancellation_query_list.Add(new result_cancellation
                                    {
                                        transaction_id = CSV_list[index].transaction_id,
                                        request_id = CSV_list[index].Request_ID
                                    });
                                }
                            }
                            else
                            if (HAAD_Validation_Control(index, 2, 16, 2) && is_cancellation)
                            {
                                Logger.Info(" INDEX Value Checker ::::  " + index);

                                Logger.Info(" -*/-*/-*/-*/-*/  HAAD_Validation_Control(index, 2, 16, 2))   *--*/-*/-*/-*/");
                                //   Logger.Info("SQL File Updated with TransactionID:  " + CSV_list[index].transaction_id + " and FileName:  " + d_filename);
                                if (!is_cancellation)
                                {

                                    //Logger.Info("%%%%%%%%%%%%%%%%%%% Update List populated %%%%%%%%%%%%%%%%%%%");
                                    //Logger.Info("Update List: FileGuidID: " + guid_id + " FileIdD: " + CSV_list[index].transaction_id + " FileName: " + d_filename + " RequestSQL: " + CSV_list[index].Request_ID);
                                    //Create_Query_Update(3, file_path + "_New_Update_Query.sql", CSV_list[index].transaction_id, guid_id, d_filename, CSV_list[index].Request_ID);

                                    //Update_query_list.Add(new result_update
                                    //{
                                    //    fileguid_Sql = guid_id,
                                    //    fileid_sql = CSV_list[index].transaction_id,
                                    //    filename_sql = d_filename,
                                    //    request_sql = CSV_list[index].Request_ID
                                    //});
                                }
                                else if (is_cancellation)
                                {
                                    Logger.Info("%%%%%%%%%%%%%%%%%%% Cancellation List populated %%%%%%%%%%%%%%%%%%%");
                                    Logger.Info("Cancellation List: TransactionID: " + CSV_list[index].transaction_id + " RequestID: " + CSV_list[index].Request_ID);
                                    Create_Query_Cancellation(3, file_path + "_New_Update_Cancellation.sql", CSV_list[index].transaction_id, CSV_list[index].Request_ID);

                                    Cancellation_query_list.Add(new result_cancellation
                                    {
                                        transaction_id = CSV_list[index].transaction_id,
                                        request_id = CSV_list[index].Request_ID
                                    });
                                }
                            }

                            else
                            {
                                Create_Query_CancellationforInvalidIDs(3, file_path + "_New_Cancellation_ForInvalid.sql", CSV_list[index].transaction_id, CSV_list[index].Request_ID);

                            }





                        }

                        #endregion



                        //   ADDING CODE TO CHECK IF THERE ARE PR AVAILABLE AND CANCELLED OR NOT -- ENDS HERE


                        Case9_CheckforRejections();
                        Case10_CheckforAcceptance();




                        Logger.Info("Automation Complete :");
                        Logger.Info("Total Transactions:" + (CSV_list.Count - 2));
                        Logger.Info("Update Transactions:" + Update_query_list.Count);
                        Logger.Info("Cancellation Transactions:" + Cancellation_query_list.Count);
                        if ((Update_query_list.Count) > 0)
                        {
                            Create_Query(3);
                        }
                    }
                    else
                    {
                        Logger.Info("No records found in the generated CSV !");
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
            }
        }

        public static bool HAAD_Validation_Control(int index, int direction, int filetype, int download_status)
        {
            Logger.Info("haad validation control ");
            try
            {
                bool result = false;
                XmlDocument xdoc = new XmlDocument();

                if (filetype == 32)
                {
                    Logger.Info("********Validating Condition of Prior Authourization**********");

                    if (HAAD_SearchTransaction_FullDay(index, direction, filetype, download_status))
                    {
                        List<string> checker_found = check_foundtransaction(foundtransactions, CSV_list[index].transaction_id);
                        if (checker_found.Count > 0)
                        {
                            result = HAAD_PA_Validator_WholeDay(index, checker_found);
                        }
                        else
                        {
                            if (HAAD_SearchTransaction(index, direction, filetype, download_status))
                            {
                                //Search Transaction will save the global variable foundtransactions with files.
                                //We will call PA Validator directly
                                //it wil set true only when the conditions will full fill i_e only once it will be true
                                result = HAAD_PA_Validator(index, foundtransactions);
                            }
                        }
                    }
                }
                else if (filetype == 16)
                {
                    Logger.Info("*********Validating Condition of Prior Request**********");

                    if (HAAD_SearchTransaction_FullDay(index, direction, filetype, download_status))
                    {
                        List<string> checker_found = check_foundtransaction(foundtransactions, CSV_list[index].transaction_id);
                        if (checker_found.Count > 0)
                        {
                            result = HAAD_PR_Validator_WholeDay(index, checker_found);
                        }
                        else
                        {
                            if (HAAD_SearchTransaction(index, direction, filetype, download_status))
                            {
                                //Search Transaction will save the global variable foundtransactions with files.
                                //We will call PR Validator directly
                                //It wil set true only when the conditions will full fill i_e only once it will be true
                                //It will also check the CHECKER LIST before setting result to true
                                result = HAAD_PR_Validator(index, foundtransactions);
                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        public static bool HAAD_SearchTransaction(int index, int direction, int filetype, int download_status)
        {
            Logger.Info("Haad Search Transaction   ");
            try
            {
                Logger.Info("HAAD_SearchTransaction");
                bool result = false;
                DateTime original = Convert.ToDateTime(CSV_list[index].date_range);
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                string time_tolerance = ConfigurationManager.AppSettings["TimeTolerance"];
                string DaysTOadd = ConfigurationManager.AppSettings["NumberofDaystoAdd"];

                if (DaysTOadd != "")
                {
                    end = original.AddDays(Convert.ToInt32(DaysTOadd));
                }
                else
                {
                    end = original.AddMinutes(Convert.ToInt32(time_tolerance));
                }

                if (filetype == 32)
                {
                    start = original.Add(new TimeSpan(0, -Convert.ToInt32(time_tolerance), 0));
                }
                else
                {
                    start = original.Add(new TimeSpan(0, -Convert.ToInt32(30), 0));
                }

                Logger.Info("Searching Transaction between " + start.ToString() + "  and  " + end.ToString());

                haad_ValidateTransactions.WebservicesSoapClient haad_ws = new haad_ValidateTransactions.WebservicesSoapClient();

                string WSUsername = "";
                string WSPassword = "";
                string ePartner = "";

                if (CSV_list[index].provider_login != "" && CSV_list[index].provider_password != "" && CSV_list[index].provider_login.ToUpper() != "NULL" && CSV_list[index].provider_password.ToUpper() != "NULL")
                {
                    Logger.Info("  ^^^^^^^^ Provider Login Available ^^^^^^^^^^^  ");
                    WSUsername = CSV_list[index].provider_login;
                    WSPassword = CSV_list[index].provider_password;
                    ePartner = CSV_list[index].Payer_HAAD_license;
                    // IN case of provider .. and filetype = 16 as (prior request) direction will be changed to 1 as Sent
                    if (filetype == 16)
                    {
                        direction = 1;
                    }
                    else
                        if (filetype == 32)
                    {
                        direction = 2;
                    }

                }
                else
                //  if (CSV_list[index].Payer_HAAD_login != "" && CSV_list[index].provider_password != "")
                {
                    WSUsername = CSV_list[index].Payer_HAAD_login;
                    WSPassword = CSV_list[index].Payer_HAAD_password;
                    ePartner = CSV_list[index].Provider_license;
                    // IN case of provider .. and filetype = 16 as (prior request) direction will be changed to 1 as Sent
                    if (filetype == 16)
                    {
                        direction = 2;
                    }
                    else
                        if (filetype == 32)
                    {
                        direction = 1;
                    }
                }


                search_result = haad_ws.SearchTransactions(WSUsername, WSPassword, direction, "", ePartner, filetype, download_status, "",
                    start.ToString("yyyy-MM-dd HH:mm"), end.ToString("yyyy-MM-dd HH:mm"), -1, -1, out foundtransactions, out errorrmessage);
                if (search_result == 0 && foundtransactions != "<Files></Files>")
                {
                    Logger.Info("Some Transactions found as per given date range ");
                    result = true;
                }
                else
                {
                    Logger.Info("Transaction not found for Login: " + WSUsername + " Password: " + WSPassword + " File Type: "
                        + filetype + " TransactionID: " + CSV_list[index].transaction_id + " Download Status: " + download_status);

                    Logger.Info("WebService returned:" + search_result);
                    Logger.Info("Error Message:" + errorrmessage);
                    result = false;
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        public static bool HAAD_SearchTransaction_FullDay(int index, int direction, int filetype, int download_status)
        {
            Logger.Info("haad search transaction full day   ");
            try
            {
                bool result = false;
                DateTime original = Convert.ToDateTime(CSV_list[index].date_range);
                string time_tolerance = ConfigurationManager.AppSettings["TimeTolerance"];
                string NumberofDaystoAdd = ConfigurationManager.AppSettings["NumberofDaystoAdd"];

                DateTime end = original.AddDays(double.Parse(NumberofDaystoAdd));
                DateTime start = original.AddHours(-1);
                Logger.Info("Searching Transaction between " + start.ToString() + "  and  " + end.ToString());
                Logger.Info("Searching Transaction for Whole Day");

                string WSUsername = "";
                string WSPassword = "";
                string ePartner = "";

                if (CSV_list[index].provider_login != "" && CSV_list[index].provider_password != "" && CSV_list[index].provider_login.ToUpper() != "NULL" && CSV_list[index].provider_password.ToUpper() != "NULL")
                {
                    Logger.Info("  ^^^^^^^^ Provider Login Available ^^^^^^^^^^^  ");
                    WSUsername = CSV_list[index].provider_login;
                    WSPassword = CSV_list[index].provider_password;
                    ePartner = CSV_list[index].Payer_HAAD_license;
                    // IN case of provider .. and filetype = 16 as (prior request) direction will be changed to 1 as Sent
                    if (filetype == 16)
                    {
                        direction = 1;
                    }
                    else
                        if (filetype == 32)
                    {
                        direction = 2;
                    }
                }
                else
                // if (CSV_list[index].Payer_HAAD_login != "" && CSV_list[index].provider_password != "")
                {
                    WSUsername = CSV_list[index].Payer_HAAD_login;
                    WSPassword = CSV_list[index].Payer_HAAD_password;
                    ePartner = CSV_list[index].Provider_license;
                    // IN case of provider .. and filetype = 16 as (prior request) direction will be changed to 1 as Sent
                    if (filetype == 16)
                    {
                        direction = 2;
                    }
                    else
                        if (filetype == 32)
                    {
                        direction = 1;
                    }



                }

                haad_ValidateTransactions.WebservicesSoapClient haad_ws = new haad_ValidateTransactions.WebservicesSoapClient();
                search_result = haad_ws.SearchTransactions(WSUsername, WSPassword, direction, "", ePartner, filetype, download_status, "",
                    start.ToString("yyyy-MM-dd HH:mm"), end.ToString("yyyy-MM-dd HH:mm"), -1, -1, out foundtransactions, out errorrmessage);
                if (search_result == 0 && foundtransactions != "<Files></Files>")
                {
                    Logger.Info("Found Transactions");
                    result = true;
                }
                else
                {
                    Logger.Info("Transaction not found for Login: " + WSUsername + " Password: " + WSPassword + " File Type: "
                        + filetype + " TransactionID: " + CSV_list[index].transaction_id + " Download Status: " + download_status);

                    Logger.Info("WebService returned:" + search_result);
                    Logger.Info("Error Message:" + errorrmessage);
                    result = false;
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        public static bool HAAD_Download_File(int index, string fileid)
        {
            Logger.Info("haad download file   ");
            try
            {
                bool result = false;
                string d_filename2 = "";
                string to_download = ConfigurationManager.AppSettings["DownloadFiles"].ToString();
                string download_path = ConfigurationManager.AppSettings["DownloadLocation"].ToString();

                if (download_path == "")
                {
                    Logger.Error("-------File Download Location is not set files cannot be downloaded ----");
                }
                else

                    if (!Directory.Exists(download_path))
                {
                    Logger.Error("*********** File Download Location path DOES NOT EXISTS. Files cannot be downloaded ******");
                }


                string WSUsername = "";
                string WSPassword = "";


                if (CSV_list[index].provider_login != "" && CSV_list[index].provider_password != "" && CSV_list[index].provider_login.ToUpper() != "NULL" && CSV_list[index].provider_password.ToUpper() != "NULL")
                {

                    Logger.Info("  ^^^^^^^^ Provider Login Available ^^^^^^^^^^^  ");
                    WSUsername = CSV_list[index].provider_login;
                    WSPassword = CSV_list[index].provider_password;


                }
                else
                // if (CSV_list[index].Payer_HAAD_login != "" && CSV_list[index].provider_password != "")
                {
                    WSUsername = CSV_list[index].Payer_HAAD_login;
                    WSPassword = CSV_list[index].Payer_HAAD_password;

                }

                haad_ValidateTransactions.WebservicesSoapClient haad_ws = new haad_ValidateTransactions.WebservicesSoapClient();
                download_result = haad_ws.DownloadTransactionFile(WSUsername, WSPassword,
                    fileid, out d_filename2, out d_file, out d_errormessage);
                if (download_result == 0)
                {

                    Logger.Info("File Downloaded Successfully!! Login:" + WSUsername + " Password:"
                        + WSPassword + " FileID:" + fileid);

                    if (Path.GetExtension(d_filename2).ToString() == ".zip" || Path.GetExtension(d_filename2).ToString() == ".ZIP")
                    {
                        Logger.Info("File is in ZIP format FileID:" + fileid);
                        if (zip_control2((Convert.ToBase64String(d_file)), d_filename2, d_file))
                        {
                            Logger.Info("File Zip extraction was Successfull");
                            d_filename = d_filename2;
                            if (to_download.ToUpper() == "TRUE")
                            {
                                using (StreamWriter text = File.CreateText(download_path + d_filename2 + ".xml"))
                                {
                                    text.Write(file_content);
                                }
                            }
                            result = true;
                        }
                        else
                        {
                            Logger.Info("File Zip extraction Failed for FileID:" + fileid);
                        }
                    }
                    else
                    {
                        file_content = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Convert.ToBase64String(d_file)));
                        d_filename = d_filename2;
                        if (to_download.ToUpper() == "TRUE")
                        {
                            using (StreamWriter text = File.CreateText(download_path + d_filename2))
                            //using (StreamWriter text = File.CreateText(download_path + d_filename2 + ".xml"))


                            {
                                text.Write(file_content);
                            }
                        }
                        result = true;
                    }
                }
                else
                {
                    Logger.Info("File Download Fail!\nLogin: " + WSUsername + " Password: " + WSPassword + " FileID: " + fileid);
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured !" + ex.Message);
                return false;
            }
        }

        public static bool HAAD_PA_Validator(int index, string transactions)
        {
            Logger.Info("Haad PA Validator  with values index:  " + index.ToString() + "    transaction   " + transactions.Length.ToString());

            bool result = false;

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(transactions);

            XmlNodeList files = xdoc.GetElementsByTagName("File");
            try
            {

                Logger.Info("HAAD_PA_Validator --  No of Files : " + files.Count.ToString());
                System.Threading.Tasks.Parallel.ForEach(files.Cast<XmlNode>(), (XmlNode file) =>
                //  foreach (XmlNode file in files)
                {
                    string guid_id2 = file.Attributes["FileID"].Value;
                    Logger.Info("Downloading Transaction for Prior Authourization: FileID:" + guid_id2 + "");
                    if (HAAD_Download_File(index, guid_id2))
                    {
                        xdoc.Load(GenerateStreamFromString(file_content));
                        string authourization_id2 = "";
                        string ID_payer2 = "";
                        if (xdoc.SelectSingleNode("Prior.Authorization/Authorization/ID") != null)
                        {
                            authourization_id2 = xdoc.SelectSingleNode("Prior.Authorization/Authorization/ID").InnerText;
                        }
                        if (xdoc.SelectSingleNode("Prior.Authorization/Authorization/IDPayer") != null)
                        {
                            ID_payer2 = xdoc.SelectSingleNode("Prior.Authorization/Authorization/IDPayer").InnerText;
                        }
                        if (authourization_id2 == CSV_list[index].transaction_id)
                        {
                            if (ID_payer2 == CSV_list[index].ID_Payer || ID_payer2 == sql_automation_process.getIDPayer(CSV_list[index].ID_Payer))
                            {
                                Logger.Info("%%%%%%%%%%%%%%%%%%% Prior_Authorization : Transaction Matched with TransactionID:  " + CSV_list[index].transaction_id + " and IDPayer:" + CSV_list[index].ID_Payer + " %%%%%%%%%%%%%%%%%%%");
                                guid_id = guid_id2;
                                result = true;
                            }
                            Create_Query_Update(3, file_path + "_HAAD_VALIDATOR_New_Update_Query.sql", CSV_list[index].transaction_id, guid_id, d_filename, CSV_list[index].Request_ID);

                        }
                        else
                        {
                            Logger.Info("Prior Authorization : TransactionID:" + CSV_list[index].transaction_id + " Not Matched with AuthourizationID:  " + authourization_id2);
                        }
                    }
                }
                );
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception Occured! " + ex.Message);
                return result;
            }
        }

        public static bool HAAD_PA_Validator_WholeDay(int index, List<string> transaction)
        {

            Logger.Info("haad pa validator whole day   ");
            bool result = false;
            XmlDocument xdoc = new XmlDocument();
            System.Threading.Tasks.Parallel.ForEach(transaction, (fileID) =>
            // foreach (string fileID in transaction)
            {
                string guid_id2 = fileID;
                Logger.Info("Downloading Transaction for Prior Authourization: FileID:" + guid_id2 + "");
                if (HAAD_Download_File(index, guid_id2))
                {
                    xdoc.Load(GenerateStreamFromString(file_content));
                    string authourization_id2 = xdoc.SelectSingleNode("Prior.Authorization/Authorization/ID").InnerText;
                    string ID_payer2 = xdoc.SelectSingleNode("Prior.Authorization/Authorization/IDPayer").InnerText;
                    if (authourization_id2 == CSV_list[index].transaction_id)
                    {
                        if (ID_payer2 == CSV_list[index].ID_Payer)
                        {
                            Logger.Info("%%%%%%%%%%%%%%%%%%% FOUND IN WHOLE DAY SEARCH %%%%%%%%%%%%%%%%%%%");
                            Logger.Info("%%%%%%%%%%%%%%%%%%% Prior_Authorization : Transaction Matched with TransactionID:  " + CSV_list[index].transaction_id + " and IDPayer:" + CSV_list[index].ID_Payer + " %%%%%%%%%%%%%%%%%%%");
                            guid_id = guid_id2;
                            result = true;
                        }
                    }
                    else
                    {
                        Logger.Info("Prior Authorization : TransactionID:" + CSV_list[index].transaction_id + " Not Matched with AuthourizationID:  " + authourization_id2);
                    }
                }
            }
            );
            return result;
        }

        public static bool HAAD_PR_Validator(int index, string file)
        {


            Logger.Info("haad PR validator  ");
            List<string> CHecker = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            bool result = false;
            string pr_auth_type = "";

            xdoc.LoadXml(foundtransactions);
            XmlNodeList downloaded_files = xdoc.GetElementsByTagName("File");
            Logger.Info("HAAD_PR_Validator --  No of Files : " + downloaded_files.Count.ToString());
            System.Threading.Tasks.Parallel.ForEach(downloaded_files.Cast<XmlNode>(), (XmlNode files) =>
            //foreach (XmlNode files in downloaded_files)
            {
                string guid_id2 = files.Attributes["FileID"].Value;
                Logger.Info("Downloading Transaction for Prior Request: FileID:" + guid_id2 + "");
                if (HAAD_Download_File(index, guid_id2))
                {
                    xdoc.Load(GenerateStreamFromString(file_content));
                    pr_auth_type = xdoc.SelectSingleNode("Prior.Request/Authorization/Type").InnerText;
                    string authourization_id2 = xdoc.SelectSingleNode("Prior.Request/Authorization/ID").InnerText;
                    if (authourization_id2 == CSV_list[index].transaction_id)
                    {
                        CHecker.Add(pr_auth_type);
                    }
                    else
                    {
                        Logger.Info("Prior_Request : TransactionID:" + CSV_list[index].transaction_id + " Not Matched with AuthourizationID:  " + authourization_id2);
                    }
                }
            }
            );
            if (CHecker.Count > 0 && !CHecker.Contains("Cancellation"))
            {
                Logger.Info("%%%%%%%%%%%%%%%%%%% Prior Request : Transaction Matched with Auth_type :   " + pr_auth_type + "  and with TransactionID:  " + CSV_list[index].transaction_id + "  %%%%%%%%%%%%%%%%%%%");
                result = true;
                is_cancellation = false;
            }
            else if (CHecker.Count > 0 && CHecker.Contains("Cancellation"))
            {
                Logger.Info("%%%%%%%%%%%%%%%%%%% Prior Request : Transaction cancellation found for TransactionID: " + CSV_list[index].transaction_id + " %%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                result = true;
                is_cancellation = true;

                Create_Query_Cancellation(3, file_path + "_PR_VALIDATOR_New_Update_Cancellation.sql", CSV_list[index].transaction_id, CSV_list[index].Request_ID);

            }

            return result;
        }

        public static bool HAAD_PR_Validator_WholeDay(int index, List<string> transaction)
        {

            Logger.Info("Haad PR Validator whole day   ");
            List<string> CHecker = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            bool result = false;
            string pr_auth_type = "";

            System.Threading.Tasks.Parallel.ForEach(transaction, (files) =>
            //foreach (string files in transaction)
            {
                string guid_id2 = files;
                Logger.Info("Downloading Transaction for Prior Request: FileID:" + guid_id2 + "");
                if (HAAD_Download_File(index, guid_id2))
                {
                    xdoc.Load(GenerateStreamFromString(file_content));
                    pr_auth_type = xdoc.SelectSingleNode("Prior.Request/Authorization/Type").InnerText;
                    string authourization_id2 = xdoc.SelectSingleNode("Prior.Request/Authorization/ID").InnerText;
                    if (authourization_id2 == CSV_list[index].transaction_id)
                    {
                        CHecker.Add(pr_auth_type);
                    }
                    else
                    {
                        Logger.Info("Prior_Request : TransactionID:" + CSV_list[index].transaction_id + " Not Matched with AuthourizationID:  " + authourization_id2);
                    }
                }
            }
            );
            if (CHecker.Count > 0 && !CHecker.Contains("Cancellation"))
            {
                Logger.Info("%%%%%%%%%%%%%%%%%%% FOUND IN WHOLE DAY SEARCH %%%%%%%%%%%%%%%%%%%");
                Logger.Info("%%%%%%%%%%%%%%%%%%% Prior Request : Transaction Matched with Auth_type: " + pr_auth_type + "  and with TransactionID:  " + CSV_list[index].transaction_id + "  %%%%%%%%%%%%%%%%%%%");
                result = true;
                is_cancellation = false;
            }
            else if (CHecker.Count > 0 && CHecker.Contains("Cancellation"))
            {
                Logger.Info("%%%%%%%%%%%%%%%%%%% FOUND IN WHOLE DAY SEARCH %%%%%%%%%%%%%%%%%%%");
                Logger.Info("%%%%%%%%%%%%%%%%%%% Prior Request : Transaction cancellation found for TransactionID: " + CSV_list[index].transaction_id + " %%%%%%%%%%%%%%%%%%%");
                result = true;
                is_cancellation = true;
            }

            return result;
        }

        #endregion

        public static void Create_Query(int trans_src)
        {
            try
            {
                Logger.Info("Creating POST OFFICE COMM Queries");
                string path = file_path + "_update_script.sql";
                string path2 = file_path + "_canceled_script.sql";

                using (StreamWriter text = new StreamWriter(path))
                {
                    for (int i = 0; i < Update_query_list.Count; i++)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("--Updating record for TransactionID:" + Update_query_list[i].fileid_sql + "\n");
                        sb.Append("UPDATE TOP (1) POST_OFFICE_COMM \nSET prior_auth_file_id = '" + Update_query_list[i].fileguid_Sql +
                            "' \n,prior_auth_file_name = '" + Update_query_list[i].filename_sql + "'\n");
                        sb.Append("WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = '" + Update_query_list[i].fileid_sql + "')");
                        sb.Append("and trans_id = '" + Update_query_list[i].request_sql + "'\nGO\n\n");
                        sb.Append("------------------------------------------------------\n");
                        sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 3\n");
                        sb.Append("WHERE request_id = '" + Update_query_list[i].fileid_sql + "'\n");
                        sb.Append("AND ID = '" + Update_query_list[i].request_sql + "'\n");
                        sb.Append("AND state_id = 2 AND trans_src = (" + trans_src + ")\nGO \n\n");

                        text.Write(sb);
                    }
                    Logger.Info("File Created Successfully for POST OFFICE COMM Queries");
                }
                using (StreamWriter text = new StreamWriter(path2))
                {
                    for (int i = 0; i < Cancellation_query_list.Count; i++)
                    {
                        if (Cancellation_query_list[i].transaction_id != null)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("--Updating Cancellation record for TransactionID:" + Cancellation_query_list[i].transaction_id + "\n");
                            sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 8\n");
                            sb.Append("WHERE request_id = '" + Cancellation_query_list[i].transaction_id + "'\n");
                            sb.Append("AND ID = '" + Cancellation_query_list[i].request_id + "'\n");
                            sb.Append("AND state_id = 2 AND trans_src = (" + trans_src + ")\nGO \n\n");
                            text.Write(sb);
                        }
                    }
                    Logger.Info("File Created Successfully for CANCELLATION Queries");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public static void Create_Query_Update(int trans_src, string path, string fileid_sql, string fileguid_Sql, string filename_sql, string request_sql)
        {
            Logger.Info("Creating query for UPDATE in directory:" + path);
            try
            {
                using (StreamWriter text = new StreamWriter(path, true))
                {

                    StringBuilder sb = new StringBuilder();
                    // sb.Append("------------------------------------------------------\n");

                    sb.Append(" -- ^^^^^Updating record for TransactionID: " + fileid_sql + " ^^^^^^\n");
                    sb.Append("UPDATE TOP (1) POST_OFFICE_COMM \nSET prior_auth_file_id = '" + fileguid_Sql +
                        "' \n,prior_auth_file_name = '" + filename_sql + "'\n");
                    sb.Append("WHERE trans_id in (select ID from AUTHORIZATION_TRANSACTION where request_id = '" + fileid_sql + "')");
                    sb.Append("and trans_id = '" + request_sql + "'\nGO\n\n");
                    // sb.Append("------------------------------------------------------\n");
                    sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 3\n");
                    sb.Append("WHERE request_id = '" + fileid_sql + "'\n");
                    sb.Append("AND ID = '" + request_sql + "'\n");
                    sb.Append("AND state_id = 2 AND trans_src = (" + trans_src + ")\nGO \n\n");
                    sb.Append("------------------------------------------------------\n");

                    text.Write(sb);

                    Logger.Info("File Created Successfully for POST OFFICE COMM Queries");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public static void Create_Query_Cancellation(int trans_src, string path, string transaction_id, string request_id)
        {
            Logger.Info("Creating query for CANCELLATION in directory:" + path);

            try
            {
                using (StreamWriter text = new StreamWriter(path, true))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("-- ^^^^^^ Updating Cancellation record for TransactionID: " + transaction_id + "  ^^^^^^^\n");
                    sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 8\n");
                    sb.Append("WHERE request_id = '" + transaction_id + "'\n");
                    sb.Append("AND ID = '" + request_id + "'\n");
                    sb.Append("AND state_id = 2 AND trans_src = (" + trans_src + ")\nGO \n\n");
                    sb.Append("------------------------------------------------------\n");
                    text.Write(sb);
                    Logger.Info("File Created Successfully for CANCELLATION Queries");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public static void Create_Query_CancellationforInvalidIDs(int trans_src, string path, string transaction_id, string request_id)
        {
            Logger.Info("Creating query for CANCELLATION for Invalid IDs in directory:" + path);

            try
            {
                using (StreamWriter text = new StreamWriter(path, true))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("-- ^^^^^^^ Updating Cancellation record for TransactionID: " + transaction_id + " ^^^^^ \n");
                    sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 6\n");
                    sb.Append("WHERE request_id = '" + transaction_id + "'\n");
                    sb.Append("AND ID = '" + request_id + "'\n");
                    sb.Append("AND state_id = 2 AND trans_src = (" + trans_src + ")\nGO \n\n");
                    sb.Append("------------------------------------------------------\n");

                    text.Write(sb);
                    Logger.Info("File Created Successfully for CANCELLATION Queries for Invalid IDs");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public static void Create_Query_UPdateforAcceptedTransactions(int trans_src, string path, string transaction_id, string request_id)
        {
            Logger.Info("Creating query for CANCELLATION for Invalid IDs in directory:" + path);

            try
            {
                using (StreamWriter text = new StreamWriter(path, true))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("-- ^^^^^^^ Updating Cancellation record for TransactionID: " + transaction_id + " ^^^^^ \n");
                    sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 3\n");
                    sb.Append("WHERE request_id = '" + transaction_id + "'\n");
                    sb.Append("AND ID = '" + request_id + "'\n");
                    sb.Append("AND state_id = 2 AND trans_src = (" + trans_src + ")\nGO \n\n");
                    sb.Append("------------------------------------------------------\n");

                    text.Write(sb);
                    Logger.Info("File Created Successfully for CANCELLATION Queries for Invalid IDs");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public static void Case2_CheckforDuplicates()
        {
            try
            {
                Logger.Info(" Case 2 for HAAD : Case2_CheckforDuplicates  ");

                sql_automation_process.list_1.Clear();

                foreach (var item in CSV_list)
                {
                    data_struct_Q1 q1 = new data_struct_Q1();
                    q1.transactiond = item.transaction_id;
                    q1.idpayer = item.ID_Payer;
                    q1.requestid = item.Request_ID;

                    sql_automation_process.list_1.Add(q1);

                }
                //  sql_automation_process.list_1 = CSV_list;
                sql_automation_process.SQL_Control(2, "PBMM");
                list_2_Haad = sql_automation_process.list_2;

                if (list_2_Haad.Count > 0)
                {
                    Logger.Info("Sorting and Matching data for Case 2");
                    for (int i = 0; i < CSV_list.Count; i++)
                    {
                        for (int j = 0; j < list_2_Haad.Count; j++)
                        {
                            if (CSV_list[i].transaction_id == list_2_Haad[j].requestid)
                            {
                                Logger.Info("\n######################### Match Found !\n RequestID:" + CSV_list[i].transaction_id + " ID:" + CSV_list[i].Request_ID + "  ############################ \n");
                                // CSV_list.RemoveAt(i); 
                                //Logger.Info("\n New Count of Array: \n" +CSV_list.Count);
                                Create_Query_Cancellation(3, file_path + "_Duplicate_Transaction_Cancellation.sql", CSV_list[i].transaction_id, CSV_list[i].Request_ID);


                            }
                        }
                    }


                    foreach (var item in list_2_Haad)
                    {
                        CSV_list.Remove(CSV_list.Find(x => x.transaction_id == item.requestid));
                    }
                }


            }
            catch (Exception ex)
            {

                Logger.Info(" Case2_CheckforDuplicates  - -  error  " + ex);
            }


        }

        public static void Case9_CheckforRejections()
        {
            try
            {
                Logger.Info(" Case 9 for HAAD : Case9_CheckforDuplicates  ");


                sql_automation_process.list_1.Clear();

                foreach (var item in CSV_list)
                {
                    data_struct_Q1 q1 = new data_struct_Q1();
                    q1.transactiond = item.transaction_id;
                    q1.idpayer = item.ID_Payer;
                    q1.requestid = item.Request_ID;

                    sql_automation_process.list_1.Add(q1);

                }
                //  sql_automation_process.list_1 = CSV_list;
                sql_automation_process.list_9.Clear();
                sql_automation_process.SQL_Control(9, "PBMM");
                list_9_Haad = sql_automation_process.list_9;

                if (list_9_Haad.Count > 0)
                {
                    Logger.Info("Sorting and Matching data for Case 2");
                    for (int i = 0; i < CSV_list.Count; i++)
                    {
                        for (int j = 0; j < list_9_Haad.Count; j++)
                        {
                            if (CSV_list[i].transaction_id == list_9_Haad[j])
                            {
                                Logger.Info("\n######################### Match Found !\n RequestID:" + CSV_list[i].transaction_id + " ID:" + CSV_list[i].Request_ID + "  ############################ \n");
                                // CSV_list.RemoveAt(i); 
                                //Logger.Info("\n New Count of Array: \n" +CSV_list.Count);
                                Create_Query_Cancellation(3, file_path + "_HAAD_Case_9_Transaction_REJECTION_Cancellation.sql", CSV_list[i].transaction_id, CSV_list[i].Request_ID);


                            }
                        }
                    }


                    foreach (var item in list_9_Haad)
                    {
                        CSV_list.Remove(CSV_list.Find(x => x.transaction_id == item));
                    }
                }


            }
            catch (Exception ex)
            {

                Logger.Info(" Case2_CheckforDuplicates  - -  error  " + ex);
            }


        }

        public static void Case10_CheckforAcceptance()
        {
            try
            {
                Logger.Info(" Case 10 for HAAD : Case10_CheckforAcceptance  ");


                sql_automation_process.list_1.Clear();

                foreach (var item in CSV_list)
                {
                    data_struct_Q1 q1 = new data_struct_Q1();
                    q1.transactiond = item.transaction_id;
                    q1.idpayer = item.ID_Payer;
                    q1.requestid = item.Request_ID;

                    sql_automation_process.list_1.Add(q1);

                }
                //  sql_automation_process.list_1 = CSV_list;
                sql_automation_process.list_10.Clear();
                sql_automation_process.SQL_Control(10, "PBMM");
                list_10_Haad = sql_automation_process.list_10;

                if (list_10_Haad.Count > 0)
                {
                    Logger.Info("Sorting and Matching data for Case 10");
                    for (int i = 0; i < CSV_list.Count; i++)
                    {
                        for (int j = 0; j < list_10_Haad.Count; j++)
                        {
                            if (CSV_list[i].transaction_id == list_10_Haad[j])
                            {
                                Logger.Info("\n######################### Match Found !\n RequestID:" + CSV_list[i].transaction_id + " ID:" + CSV_list[i].Request_ID + "  ############################ \n");
                                // CSV_list.RemoveAt(i); 
                                //Logger.Info("\n New Count of Array: \n" +CSV_list.Count);
                               
                            Create_Query_UPdateforAcceptedTransactions(3, file_path + "_HAAD_Case_10_PBMM_ACCEPTED_PA_Transaction_UPdate.sql", CSV_list[i].transaction_id, CSV_list[i].Request_ID);


                            }
                        }
                    }


                    foreach (var item in list_10_Haad)
                    {
                        CSV_list.Remove(CSV_list.Find(x => x.transaction_id == item));
                    }
                }


            }
            catch (Exception ex)
            {

                Logger.Info(" Case2_CheckforDuplicates  - -  error  " + ex);
            }


        }

    }
}
