using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Automation
{
    public class parse_CSV
    {
        public string transaction_id { get; set; }
        public string date_range { get; set; }
        public string Request_ID { get; set; }
        public string provider_login { get; set; }
        public string provider_password { get; set; }
        public string Payer_HAAD_login { get; set; }
        public string Payer_HAAD_password { get; set; }
        public string Payer_DHA_login { get; set; }
        public string Payer_DHA_password { get; set; }

        public string ID_Payer { get; set; }


        // Added by Fazeel for ePartner Logic for HAAD Search Criteria
        public string Payer_HAAD_license { get; set; }
        public string Provider_license { get; set; }

    }

    public class result_update
    {
        public string filename_sql { get; set; }
        public string fileid_sql { get; set; }
        public string request_sql { get; set; }
        public string fileguid_Sql { get; set; }
    }

    public class result_cancellation
    {
        public string transaction_id { get; set; }
        public string request_id { get; set; }
       
    }
}
