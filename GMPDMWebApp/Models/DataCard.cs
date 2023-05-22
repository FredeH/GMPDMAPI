using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMPDMWebApp.Models
{
    public class DataCard
    {
        public string PartNo { get; set; }
        [ForeignKey("FileName")]
        public File File { get; set; }
        public string State { get; set; }
    }
}