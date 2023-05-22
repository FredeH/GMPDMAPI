using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GMPDMWebApp.Models
{
    public class File
    {
        [Required]
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}