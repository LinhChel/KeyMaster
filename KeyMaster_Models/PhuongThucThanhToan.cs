using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class PhuongThucThanhToan
    {
        [Key]
        public Guid IdPhuongThucThanhToan { get; set; }
        public string TenPhuongThucThanhToan { get; set; }
        public string TrangThai { get; set; }
    }
}
