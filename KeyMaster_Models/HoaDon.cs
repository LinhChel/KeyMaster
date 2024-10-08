using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class HoaDon
    {
        [Key]
        public Guid IdHoaDon { get; set; }
        public Guid IdNguoiDung { get; set; }
        public Guid IdPhuongThucThanhToan { get; set; }
        public int SoLuong { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        public decimal TongTien
        {
            get { return Gia * SoLuong; }
        }
        public string TrangThai { get; set; }
        // Ngày Vận Chuyển bắt buộc
        public DateTime NgayVanChuyen { get; set; }

        // Ngày Giao Hàng Dự Kiến có thể null (không bắt buộc)
        public DateTime? NgayGiaoHangDuKien { get; set; }
        public DateTime? NgayNhanHang { get; set; }
        public decimal PhiVanChuyen { get; set; }
        public string GhiChu { get; set; }
        public Guid IdThongTinVanChuyen { get; set; }
        public Guid IdPhieuGiamGia { get; set; }
    }
}