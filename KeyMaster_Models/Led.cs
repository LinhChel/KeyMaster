﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class Led
    {
        [Key]
        public Guid IdLed { get; set; }
        public string TenLed { get; set; }
        public string TrangThai { get; set; }
    }
}
