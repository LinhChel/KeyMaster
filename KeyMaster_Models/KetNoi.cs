using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class KetNoi
    {
        [Key]
        public Guid IdKetNoi { get; set; }
        public string TenKetNoi { get; set; }
        public string TrangThai { get; set; }
    }
}
