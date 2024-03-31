using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(customerMetaData))]
    public partial class customer
    {
        public class customerMetaData
        {
            [DisplayName("Customer ID:")]
            public int custid { get; set; }
            
            [DisplayName("Customer Name:")]
            public string custname { get; set; }
            
            [DisplayName("Customer Address:")]
            public string address { get; set; }

            [DisplayName("Customer Phone:")]
            public string phone { get; set; }
        }
    }
}