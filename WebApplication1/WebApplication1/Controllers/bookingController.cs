using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class bookingController : Controller
    {
        tripplanning_dbEntities db = new tripplanning_dbEntities();
        

        // GET: booking
        public ActionResult Index()
        {
            var result = (from r in db.bookings join c in db.admins on r.packid equals c.packid
                            select new BookingViewModel
                            {
                                bookid = r.bookid,
                                packid = r.packid,
                                custid = r.custid,
                                price = r.price,
                                startdate = r.startdate,
                                enddate = r.enddate,
                                designation = c.designation
                            }).ToList();

            return View(result);
        }

        [HttpGet]

        public ActionResult Getpack()
        {
            var pack = db.admins.ToList();
            return Json(pack, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]

        public ActionResult Getprice(int id)
        {

            var price = (from s in db.admins where s.packid == id select s.price).ToList();
            return Json(price, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]

        public ActionResult ApplyCouponCode(int id)
        {
            var coupon = (from s in db.coupons where s.couponid == id select s.discount).ToList();
            return Json(coupon, JsonRequestBehavior.AllowGet);
            

        }
       /*[HttpPost]
        public JsonResult  GetDiscount1(coupon couponcode)
        {
            //var coupon = db.coupons.ToList();
            var test = db.coupons.ToList().Find(fds => fds.couponcode.Equals(couponcode));
                //db.coupons.SingleOrDefault(x =>x.couponcode==couponcode.ToString());

            if (test != null)
            {

                return Json(couponcode, JsonRequestBehavior.AllowGet);
                
            }
            return Json(couponcode, JsonRequestBehavior.AllowGet); //This is your missing statement
        }*/

        [HttpPost]

        public ActionResult Getid(int id)
        {
            
            var customer = (from s in db.customers where s.custid == id select s.custname).ToList();
            return Json(customer, JsonRequestBehavior.AllowGet);
           

        }

        [HttpPost]

        public ActionResult  Getpack(int packid)
        {
            var packavail = (from s in db.admins where s.packid == packid select s.packid).FirstOrDefault();
            return Json(packavail, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]

        public ActionResult GetTotalPrice(int id)
        {
            
            //admin a=new admin();
            //var totalprice0 = a.price - 10;
            var totalprice = (from s in db.admins where s.packid == id select s.price).FirstOrDefault(); ;
            var discount = (from s in db.coupons where s.couponid == 1 select s.discount).FirstOrDefault();
            var result = totalprice - discount;
            return Json(result, JsonRequestBehavior.AllowGet);

        }


        public ActionResult Save(booking book)
        {
            if (ModelState.IsValid)
            {
                db.bookings.Add(book);

                TempData["AlertMessage"] = "Booking Request is submited! ";

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(book);
        }
         

    }
}