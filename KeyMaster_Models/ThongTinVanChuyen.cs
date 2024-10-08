using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class ThongTinVanChuyen
    {
        public Guid IdThongTinVanChuyen { get; set; }
        public string DiaChi { get; set; }
        public string TenNguoiNhan { get; set; }
        public string SoDienThoai { get; set; }
        public string Diachi { get; set; }
        public string Tinh { get; set; }
        public string Huyen { get; set; }
        public string Xa { get; set; }
        public Guid IdNguoiDung { get; set; }
        public Guid IdHoaDon { get; set; }
    }
}
