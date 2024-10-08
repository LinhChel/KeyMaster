using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class LoaiSP
    {
        [Key]
        public Guid IdLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public string TrangThai { get; set; }
    }
}
