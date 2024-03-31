using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(adminMetaData))]
    public partial class admin
    {
        public class adminMetaData
        {
            
            [DisplayName("Package id:")]
            public short packid { get; set; }

            [DisplayName("No.of.Days:")]
            public Nullable<short> no_of_days { get; set; }

            [DisplayName("Designation:")]
            public string designation { get; set; }

            [DisplayName("Package Price:")]
            public Nullable<decimal> price { get; set; }
        }
        
    }
}