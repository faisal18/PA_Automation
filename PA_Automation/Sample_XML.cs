using Ionic.Zip;
using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;

namespace PA_Automation
{
    class Sample_XML
    {
        public static void parse_xml()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\Users\faisal\Desktop\PriorRequest_PF1223-868084_A023.xml");
            string auth_type = xdoc.SelectSingleNode("Prior.Request/Authorization/Type").InnerText;
            string authourization_id2 = xdoc.SelectSingleNode("Prior.Request/Authorization/ID").InnerText;
        }

        public static void download_haad_file()
        {
            string d_filename2, d_errormessage,file_content;
            byte[] d_file;
            int download_result = 1;
            haad_ValidateTransactions.WebservicesSoapClient haad_ws = new haad_ValidateTransactions.WebservicesSoapClient();

            //cfa32ff8-6b0d-40cb-83bc-0880ea6e3963 ERROR
            //00527acb-b594-4160-a31e-19db2b5f1e60 NORMAL

            download_result = haad_ws.DownloadTransactionFile("Abu Dhabi National", "vame4Pen", "00527acb-b594-4160-a31e-19db2b5f1e60", out d_filename2, out d_file, out d_errormessage);
            if (download_result == 0)
            {
                file_content = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Convert.ToBase64String(d_file)));
                xml_control(file_content);
                zip_control2(Convert.ToBase64String(d_file), d_filename2,d_file);
            }
        }

        public static void xml_control(string filecontent)
        {
            XmlDocument xdoc = new XmlDocument();
            //xdoc.LoadXml(@"C:\Users\faisal\Desktop\error.xml);
            xdoc.Load(@"C:\Users\faisal\Desktop\error.xml");
            string pr_auth_type = xdoc.SelectSingleNode("Prior.Request/Authorization/Type").InnerText;
            string authourization_id2 = xdoc.SelectSingleNode("Prior.Request/Authorization/ID").InnerText;
        }

        public static void zip_control2(string filecontent, string filename, byte[] byte_file)
        {
            string zip_path = @"C:\tmp\" + Path.GetFileName(filename);
            System.IO.File.WriteAllBytes(zip_path, byte_file);
            string extract_path = zip_path + "_" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
            using (var zip = ZipFile.Read(zip_path))
            {
                zip.ExtractAll(extract_path,ExtractExistingFileAction.OverwriteSilently);
                zip.Dispose();
            }

            string[] filearray = Directory.GetFiles(extract_path);
            string new_path = "";
            foreach (string s in filearray)
            {
                new_path = "C:\\tmp\\" + Path.GetFileName(s);
                System.IO.File.Copy(s,"C:\\tmp\\"+Path.GetFileName(s));
            }

            using (StreamReader read = new StreamReader(new_path))
            {
                StringBuilder sb = new StringBuilder();
                string text;
                while ((text = read.ReadLine()) != null)
                {
                    sb.Append(text);
                }
                text = sb.ToString();
            }
            File.Delete(new_path);
            File.Delete(zip_path);
            Directory.Delete(extract_path,true);
        }
    }
}
