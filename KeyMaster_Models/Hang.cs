using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class Hang
    {
        [Key]
        public Guid IdHang { get; set; }
        public string TenHang { get; set; }
        public string TrangThai { get; set; }
    }
}
