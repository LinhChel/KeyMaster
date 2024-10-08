using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class NguoiDung
    {
        [Key]
        public Guid IdNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string HovaTen { get; set; }
        public string SoDienThoai { get; set; }
        public string Avatar { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int CCCD { get; set; }
        public string TrangThai { get; set; }
        public Guid IdVaiTro { get; set; }
    }
}
