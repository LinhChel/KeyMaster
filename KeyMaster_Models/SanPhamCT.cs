using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class SanPhamCT
    {
        [Key]
        public Guid IdSanPhamCT { get; set; }
        public Guid IdSanPham { get; set; }
        public Guid IdMau { get; set; }
        public Guid IdLed { get; set; }
        public Guid IdLoaiKN { get; set; }
        public Guid IdHang { get; set; }
        public Guid IdKeyCap { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        public int Soluong { get; set; }
        public string? ThongTinThem { get; set; }
    }
}
