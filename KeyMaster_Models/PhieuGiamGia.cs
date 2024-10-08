using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class PhieuGiamGia
    {
        [Key]
        public Guid IdPhieuGiamGia { get; set; }
        public string TenGiamGia { get; set; }
        public string MucGiamGia { get; set; }
        public string DieuKien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
        public string KieuGiamGia { get; set; }
        public int SoLuong { get; set; }
    }
}
 