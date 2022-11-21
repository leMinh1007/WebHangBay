using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHangBay.Models
{
    public class ChuyenBay
    {
        public string FlightNo { set; get; }
        public DateTime Ngay { set; get; }
        public string DiemDi { set; get; }
        public string DiemDen { set; get; }

        public List<ChuyenBay> KhoiTaoChuyenBay()
        {
            List<ChuyenBay> danhSachChuyenBay = new List<ChuyenBay>();


            danhSachChuyenBay.Add(new ChuyenBay()
            {
                FlightNo = "00001",
                Ngay = new DateTime(2022,11,10),
                DiemDi = "Ha Noi",
                DiemDen = "Sai Gon",
            });

            danhSachChuyenBay.Add(new ChuyenBay()
            {
                FlightNo = "00005",
                Ngay = new DateTime(2022, 9, 10),
                DiemDi = "Dak Lak",
                DiemDen = "Nha Trang",
            });
            return danhSachChuyenBay;
        }
    }
}