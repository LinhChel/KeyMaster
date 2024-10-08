using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class Mau
    {
        [Key]
        public Guid IdMau { get; set; }
        public string TenMau { get; set; }
        public string TrangThai { get; set; }
    }
}
