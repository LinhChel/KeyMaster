using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class GioHangCT
    {
        [Key]
        public Guid IdGioHangCT { get; set; }
        public Guid IdSanPhamCT { get; set; }
        public Guid IdGioHang { get; set; }
        public int SoLuong { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        public decimal ThanhTien
        {
            get { return Gia * SoLuong; }
        }
    }
}
