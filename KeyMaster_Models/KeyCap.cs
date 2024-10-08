using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class KeyCap
    {
        [Key]
        public Guid IdKeyCap { get; set; }
        public string TenKeyCap { get; set; }
        public string TrangThai { get; set; }
    }
}
