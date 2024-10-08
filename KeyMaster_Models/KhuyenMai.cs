using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class KhuyenMai
    {
        [Key]
        public Guid IdKhuyenMai { get; set; }
        public string TenKhuyenMai { get; set; }
        // Mức Giảm Giá Dự Kiến có thể là số thập phân
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MucGiamGia { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
    }
}
