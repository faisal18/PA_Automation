using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PA_Automation
{
    class rachel_transactions
    {
        public static List<string> transcation = new List<string>();
        public static void parse_csv()
        {
            string file_path = @"C:\Users\faisal\Desktop\rachel";
            using (var fs = File.OpenRead(file_path + ".csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    transcation.Add(values[0].Trim());
                }
            }
            using (StreamWriter text = new StreamWriter(file_path + ".sql"))
            {
                for (int i = 0; i < transcation.Count; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE TOP (1) AUTHORIZATION_TRANSACTION \nSET state_id = 6\n");
                    sb.Append("WHERE request_id = '" + transcation[i] + "'\n");
                    text.Write(sb);
                }
            }
        }

    }
}
