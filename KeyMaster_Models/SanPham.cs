using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class SanPham
    {
        [Key]
        public Guid IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        public Guid IdImage { get; set; }
        public Guid IdLoaiSP { get; set; }
    }
}
