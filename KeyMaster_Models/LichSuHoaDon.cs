using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class LichSuHoaDon
    {
        [Key]
        public Guid IdLichSuHoaDon { get; set; }
        public Guid IdHoaDon { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayNhanHang { get; set; }
    }
}
