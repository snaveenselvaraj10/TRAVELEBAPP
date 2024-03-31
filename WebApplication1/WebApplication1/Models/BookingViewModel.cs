using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BookingViewModel
    {

        public short bookid { get; set; }
        public Nullable<short> packid { get; set; }
        public Nullable<short> custid { get; set; }
        public Nullable<decimal> price { get; set; }

        public Nullable<decimal> totalprice { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        
        public string designation { get; set; }

    }
}