
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text;

namespace PA_Automation
{

    #region OMAR CSV

    public static class CSV2SQL
    {
        public static void main()
        {
            CSV_Khelo.parse_csv_herbal();
            CSV_Khelo.parse_csv_vitmain();
            CSV_Khelo.parse_csv_human();
            CSV_Khelo.parse_csv_payer();
        }
    }

    public static class CSV_Khelo
    {

        public static List<struct_vitamin_csv> vitmain_list = new List<struct_vitamin_csv>();
        public static List<struct_herbal_csv> herbal_list = new List<struct_herbal_csv>();
        public static List<struct_human_csv> human_list = new List<struct_human_csv>();
        public static List<struct_payer_csv> payer_list = new List<struct_payer_csv>();


        public static void parse_csv_vitmain()
        {
            string file_path = @"C:\Users\faisal\Desktop\Excel Omar\";
            using (var fs = File.OpenRead(file_path + "vitamin.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    vitmain_list.Add(new struct_vitamin_csv { reg_key = values[0], ingredients = values[1], tradename = values[2] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_vitmain" + ".sql"))
            {
                for (int i = 1; i < vitmain_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    //sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 6\n");
                    //sb.Append("WHERE request_id = '" + column1[i] + "'\n");
                    sb.Append("--USE [DHPO]\n" +
                    "INSERT INTO [dbo].[tblCodes]\n" +
                    "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                    "VALUES\n" +
                    "('" + vitmain_list[i].reg_key + "','" + vitmain_list[i].tradename + "','" + vitmain_list[i].ingredients + "','Drug',1,getdate() + 365)\n" +
                    "GO\n\n");
                    text.Write(sb);
                }
            }

        }
        public static void parse_csv_herbal()
        {
            string file_path = @"C:\Users\faisal\Desktop\Excel Omar\";
            using (var fs = File.OpenRead(file_path + "herbal.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    herbal_list.Add(new struct_herbal_csv { reg_key = values[0], ingredients = values[1], tradename = values[2] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_herbal" + ".sql"))
            {
                for (int i = 1; i < herbal_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    //sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 6\n");
                    //sb.Append("WHERE request_id = '" + column1[i] + "'\n");
                    sb.Append("--USE [DHPO]\n" +
                    "INSERT INTO [dbo].[tblCodes]\n" +
                    "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                    "VALUES\n" +
                    "('" + herbal_list[i].reg_key + "','" + herbal_list[i].tradename + "','" + herbal_list[i].ingredients + "','Drug',1,getdate() + 365)\n" +
                    "GO\n\n");
                    text.Write(sb);
                }
            }

        }
        public static void parse_csv_human()
        {
            string file_path = @"C:\Users\faisal\Desktop\Excel Omar\";
            using (var fs = File.OpenRead(file_path + "human.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    human_list.Add(new struct_human_csv { reg_key = values[0], trade_ingredient = values[1], tradename = values[2] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_human" + ".sql"))
            {
                for (int i = 1; i < human_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    //sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 6\n");
                    //sb.Append("WHERE request_id = '" + column1[i] + "'\n");
                    sb.Append("--USE [DHPO]\n" +
                    "INSERT INTO [dbo].[tblCodes]\n" +
                    "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                    "VALUES\n" +
                    "('" + human_list[i].reg_key + "','" + human_list[i].tradename + "','" + human_list[i].trade_ingredient + "','Drug',1,getdate() + 365)\n" +
                    "GO\n\n");
                    text.Write(sb);
                }
            }

        }
        public static void parse_csv_payer()
        {
            string file_path = @"C:\Users\faisal\Desktop\Excel Omar\";
            using (var fs = File.OpenRead(file_path + "payer.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    payer_list.Add(new struct_payer_csv { payercode = values[0], payername = values[1] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_payer" + ".sql"))
            {
                for (int i = 1; i < payer_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append("--USE [DHPO] \n" +
                    "--GO \n" +
                    "INSERT INTO [dbo].[Payers] \n" +
                    "([PayerCode],[PayerName],[PayerTypeID],[CreatedBy],[CreationDate],[IsActive],[Password],[UserName]) \n" +
                    "VALUES \n" +
                    "(" + payer_list[i].payercode + ",'" + payer_list[i].payername + "',5,1,GETDATE(),1,'" + payer_list[i].payercode + "','" + payer_list[i].payercode + "') \n" +
                    "GO\n\n");
                    text.Write(sb);
                }
            }

        }
    }

    public class struct_vitamin_csv
    {
        public string reg_key { get; set; }
        public string ingredients { get; set; }
        public string tradename { get; set; }
    }

    public class struct_herbal_csv
    {
        public string reg_key { get; set; }
        public string ingredients { get; set; }
        public string tradename { get; set; }
    }

    public class struct_human_csv
    {
        public string reg_key { get; set; }
        public string trade_ingredient { get; set; }
        public string tradename { get; set; }
    }

    public class struct_payer_csv
    {
        public string payercode { get; set; }
        public string payername { get; set; }
    }

    #endregion

    static class EXCEL_khelo

    {
        public static void read_excel()
        {
            string path = @"C:\Users\faisal\Desktop\Dashboard\MonitoringData.xlsx";
            string provider = "Microsoft.Jet.OLEDB.12.0";
            string extnded_prop = "'Excel 12.0;HDR=Yes;'";
            string con = @"Provider=" + provider + "; Data Source=" + path + ";" + @"Extended Properties=" + extnded_prop;
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("select * from [Vitmain]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var row1col10 = dr[0];
                    }
                }
            }

        }
    }

    #region Query Generate

    public static class CSV_Parser_Main
    {
        public static void main()
        {
            CSV_Parser.parse_csv_cpt();
            CSV_Parser.parse_csv_dental_diag();
            CSV_Parser.parse_csv_dental_proced();
            CSV_Parser.parse_csv_drugs();
            CSV_Parser.parse_csv_hcpcs();
            CSV_Parser.parse_csv_ICD9();
        }
    }

    public static class CSV_Parser
    {
        public static List<struct_cpt> cpt_list = new List<struct_cpt>();
        public static List<struct_drugs> drugs_list = new List<struct_drugs>();
        public static List<struct_dental_diagnosis> dental_diag_list = new List<struct_dental_diagnosis>();
        public static List<struct_dental_procedures> dental_procedures_list = new List<struct_dental_procedures>();
        public static List<struct_hcpcs> hcpcs_list = new List<struct_hcpcs>();
        public static List<struct_icd9> icd9_list = new List<struct_icd9>();

        public static void parse_csv_cpt()
        {
            string file_path = @"C:\Users\faisal\Desktop\Query Generate\";
            using (var fs = File.OpenRead(file_path + "CPT.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    cpt_list.Add(new struct_cpt { cpt_code = values[0], cpt_short_name = values[1], inactive = values[2] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_CPT" + ".sql"))
            {
                for (int i = 1; i < cpt_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    int inactive = 1;
                    string Validto = "GETDATE() + 365";
                    if (cpt_list[i].inactive == "Yes")
                    {
                        inactive = 0;
                        Validto = "GETDATE() - 1";
                    }
                    sb.Append(
                        "USE [ISOTPO]\n" +
                        "GO\n" +
                        "INSERT INTO [dbo].[tblCodes]\n" +
                        "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                        "VALUES\n" +
                        "('" + cpt_list[i].cpt_code + "','" + cpt_list[i].cpt_short_name + "','" + cpt_list[i].cpt_short_name + "','CPT'," + inactive + "," + Validto + ")\n" +
                        "GO\n\n"
                    );
                    text.Write(sb);
                }
            }
        }

        public static void parse_csv_drugs()
        {
            string file_path = @"C:\Users\faisal\Desktop\Query Generate\";
            using (var fs = File.OpenRead(file_path + "Drugs List.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    drugs_list.Add(new struct_drugs { drug_name = values[0], gtin = values[1] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_DRUGS" + ".sql"))
            {
                for (int i = 1; i < drugs_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append(
                        "USE [ISOTPO]\n" +
                        "GO\n" +
                        "INSERT INTO [dbo].[tblCodes]\n" +
                        "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                        "VALUES\n" +
                        "('" + drugs_list[i].gtin + "','" + drugs_list[i].drug_name + "','" + drugs_list[i].drug_name + "','DRUGS',1,GETDATE()+365)\n" +
                        "GO\n\n"
                    );
                    text.Write(sb);
                }
            }
        }

        public static void parse_csv_dental_proced()
        {
            string file_path = @"C:\Users\faisal\Desktop\Query Generate\";
            using (var fs = File.OpenRead(file_path + "Dental Procedures.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    dental_procedures_list.Add(new struct_dental_procedures { cpt_code = values[0], cpt_description = values[1] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_DentalProcedures" + ".sql"))
            {
                for (int i = 1; i < dental_procedures_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append(
                        "USE [ISOTPO]\n" +
                        "GO\n" +
                        "INSERT INTO [dbo].[tblCodes]\n" +
                        "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                        "VALUES\n" +
                        "('" + dental_procedures_list[i].cpt_code + "','" + dental_procedures_list[i].cpt_description + "','" + dental_procedures_list[i].cpt_description + "','DENTAL',1,GETDATE() + 365 )\n" +
                        "GO\n\n"
                    );
                    text.Write(sb);
                }
            }
        }

        public static void parse_csv_hcpcs()
        {
            string file_path = @"C:\Users\faisal\Desktop\Query Generate\";
            using (var fs = File.OpenRead(file_path + "HCPCS.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    hcpcs_list.Add(new struct_hcpcs { hcpcs_code = values[0], hcpcs_name = values[1], inactive = values[2] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_HCPCS" + ".sql"))
            {
                for (int i = 1; i < hcpcs_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    int inactive = 1;
                    string Validto = "GETDATE() + 365";
                    if (hcpcs_list[i].inactive == "Yes")
                    {
                        inactive = 0;
                        Validto = "GETDATE() - 1";
                    }
                    sb.Append(
                        "USE [ISOTPO]\n" +
                        "GO\n" +
                        "INSERT INTO [dbo].[tblCodes]\n" +
                        "([cCode],[cDesc],[LongDesc],[cType],[Status],[ValidTo])\n" +
                        "VALUES\n" +
                        "('" + hcpcs_list[i].hcpcs_code + "','" + hcpcs_list[i].hcpcs_name + "','" + hcpcs_list[i].hcpcs_name + "','HCPCS'," + inactive + "," + Validto + ")\n" +
                        "GO\n\n"
                    );
                    text.Write(sb);
                }
            }
        }



        public static void parse_csv_dental_diag()
        {
            string file_path = @"C:\Users\faisal\Desktop\Query Generate\";
            using (var fs = File.OpenRead(file_path + "Dental Diagnosis.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    dental_diag_list.Add(new struct_dental_diagnosis { icd_code = values[0], diagnosis = values[1] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_DentalDiagnosis" + ".sql"))
            {
                for (int i = 1; i < dental_diag_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append(
                        "USE [ISOTPO]\n" +
                        "GO\n" +
                        "INSERT INTO [dbo].[Diagnosis]\n" +
                        "([Code],[Short Description],[Medium Description],[Description])\n" +
                        "VALUES\n" +
                        "('" + dental_diag_list[i].icd_code + "','" + dental_diag_list[i].diagnosis + "','" + dental_diag_list[i].diagnosis + "','" + dental_diag_list[i].diagnosis + "')\n" +
                        "GO\n\n"
                    );
                    text.Write(sb);
                }
            }
        }

        public static void parse_csv_ICD9()
        {
            string file_path = @"C:\Users\faisal\Desktop\Query Generate\";
            using (var fs = File.OpenRead(file_path + "ICD-9.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    icd9_list.Add(new struct_icd9 { icd_code = values[0], diagnosis = values[1], inactive = values[2] });
                }
            }

            using (StreamWriter text = new StreamWriter(file_path + "_ICD9" + ".sql"))
            {
                for (int i = 1; i < icd9_list.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(
                        "USE [ISOTPO]\n" +
                        "GO\n" +
                        "INSERT INTO [dbo].[Diagnosis]\n" +
                        "([Code],[Short Description],[Medium Description],[Description])\n" +
                        "VALUES\n" +
                        "('" + icd9_list[i].icd_code + "','" + icd9_list[i].diagnosis + "','" + icd9_list[i].diagnosis + "','" + icd9_list[i].diagnosis + "')\n" +
                        "GO\n\n"
                    );
                    text.Write(sb);
                }
            }

        }

    }

    public class struct_cpt
    {
        public string cpt_code { get; set; }
        public string cpt_short_name { get; set; }
        public string inactive { get; set; }
    }

    public class struct_drugs
    {
        public string drug_name { get; set; }
        public string gtin { get; set; }
    }

    public class struct_dental_diagnosis
    {
        public string icd_code { get; set; }
        public string diagnosis { get; set; }
    }

    public class struct_dental_procedures
    {
        public string cpt_code { get; set; }
        public string cpt_description { get; set; }
    }

    public class struct_hcpcs
    {
        public string hcpcs_code { get; set; }
        public string hcpcs_name { get; set; }
        public string inactive { get; set; }
    }

    public class struct_icd9
    {
        public string icd_code { get; set; }
        public string diagnosis { get; set; }
        public string inactive { get; set; }
    }


    #endregion


    #region Dynamic List

    public static class cls_dynamic_list
    {
        public static List<dynamic> dynamic_list = new List<dynamic>();

        public static void yodar()
        {

            string input = "'abcd',123,'abcd',123\n\r'abcd',123,'abcd',123";
            string[] differences = { "\t", "\n", "\r" };
            string[] carry = input.Split(differences, StringSplitOptions.RemoveEmptyEntries);

            foreach (string parameters in carry)
            {
                string[] diff = { "," };
                string[] parameters_array = parameters.Split(diff, StringSplitOptions.RemoveEmptyEntries);
                string query = "hello @1 where are you going to @2 come here @3 dont go @4";

                for (int i = 1; i < parameters_array.Length + 1; i++)
                {
                    query = query.Replace("@" + i, parameters_array[i - 1]);
                }
            }
        }
    }


    #endregion
}
