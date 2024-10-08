using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class KieuGiamGia
    {
        [Key]
        public Guid IdKieuGiamGia { get; set; }
        public string TenKieuGiamGia { get; set; }
        public decimal GiaTriGiamGia { get; set; }
    }
}
