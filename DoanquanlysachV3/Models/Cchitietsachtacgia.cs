﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoanquanlysachV3.Models
{
    public class Cchitietsachtacgia
    {
        public string MaSach { get; set; }
        public string MaTacGia { get; set; }
        public virtual ICollection<SACH> sach { get; set; }
        public virtual ICollection<TACGIA> tacgia { get; set; }
    }
}