using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHangBay.Models;

namespace WebHangBay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {            

            return View(LichChuyenBay.listChuyenBay);
        }

       

        public ActionResult ThemMoiChuyenBay()
        {
            return View(new ChuyenBay() {Ngay = DateTime.Now });
        }
        [HttpPost]
        public ActionResult ThemMoiChuyenBay(ChuyenBay model)
        {
            //xử lý lưu
            //LichChuyenBay.listChuyenBay.Add(new ChuyenBay()
            //{
            //  FlightNo = model.FlightNo,
            //  Ngay = model.Ngay,
            //  DiemDi = model.DiemDi,
            // DiemDen = model.DiemDen,
            // });

            
             LichChuyenBay.listChuyenBay.Add(model);

             return RedirectToAction("Index");
           
            
        }
    }
}