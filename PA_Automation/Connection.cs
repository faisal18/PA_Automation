
using System.Xml;

namespace PA_Automation
{
    static class Connection
    {
        public static string run_connection(string key,string path)
        {
            //return hash_it(key).ToString();
            return get_conn(key, path);
        }

        private static string get_conn(string connect,string path)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path + "connections_server.xml");
            string query = string.Format("//*[@name='{0}']", connect);
            return xdoc.SelectSingleNode(query).InnerText.ToString();
        }
    }
}
