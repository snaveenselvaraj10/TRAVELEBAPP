using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(bookingMetaData))]
    public partial class booking
    {
        public class bookingMetaData
        {
            [Required]
            [DisplayName("Book id:")]
            public short bookid { get; set; }

            [DisplayName("Package id:")]
            public Nullable<short> packid { get; set; }

            [DisplayName("Customer id:")]
            public Nullable<short> custid { get; set; }

            [DisplayName("Price:")]
            public Nullable<decimal> price { get; set; }

            [DisplayName("Starting id:")]
            public Nullable<System.DateTime> startdate { get; set; }

            [DisplayName("Ending id:")]
            public Nullable<System.DateTime> enddate { get; set; }

            [DisplayName("Coupon:")]

            public string couponcode { get; set; }

            [DisplayName("Discount:")]
            public Nullable<decimal> discount { get; set; }

            [DisplayName("Total Price:")]
            public Nullable<decimal> totalprice { get; set; }

        }

    }
}