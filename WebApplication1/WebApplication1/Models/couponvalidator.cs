using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static WebApplication1.Models.admin;

namespace WebApplication1.Models
{
    [MetadataType(typeof(couponMetaData))]
    public partial class coupon
    {
        public class couponMetaData
        {
            [DisplayName("Coupon ID")]
            public int couponid { get; set; }

            [DisplayName("Coupon Code")]
            public string couponcode { get; set; }

            [DisplayName("Discount")]
            public Nullable<int> discount { get; set; }

            [DisplayName("Valid throw")]
            public Nullable<System.DateTime> tilldate { get; set; }
        }
    }
}