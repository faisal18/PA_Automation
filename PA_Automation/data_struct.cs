using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Automation
{

    public class data_struct_Q1
    {
        public string transactiond { get; set; }
        public string requestid { get; set; }
        public string idpayer { get; set; }
    }

    public class data_struct_Q2
    {
        public string ID { get; set; }
        public string requestid { get; set; }
        public string stateid { get; set; }
    }

    public class data_struct_Q4
    {
        public string filenmae { get; set; }
        public string fileid { get; set; }
        public string pra_authourizationcode { get; set; }
        public string paa_idpayer { get; set; }
    }

    public class result_struct_cancellation
    {
        public string transactiond { get; set; }
        public string requestid { get; set; }
        public string idpayer { get; set; }
    }

    public class result_struct_update
    {
        public string filenmae { get; set; }
        public string fileid { get; set; }
        public string pra_authourizationcode { get; set; }
        public string paa_idpayer { get; set; }
        public string requestid { get; set; }
    }

    public class result_struct_case2
    {
        public string transactionid;
        public string requestid;
    }
    

}
