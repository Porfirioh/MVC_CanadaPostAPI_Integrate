using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanadaPostRates.Models
{
    public class rate
    {
        [DisplayName("Service Type")]
        public string ServiceType { get; set; }
        [DisplayName("Transit Day")]
        public int TransitDay { get; set; }
        [DisplayName("Regular Price")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal RegularPrice { get; set; }

    }
}