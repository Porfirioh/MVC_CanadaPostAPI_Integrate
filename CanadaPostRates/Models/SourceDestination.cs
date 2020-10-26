using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanadaPostRates.Models
{
    public class SourceDestination
    {
        [Required(ErrorMessage = "Origin postalcode is required")]
        [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]", ErrorMessage = "Please enter a valid Postalcode")]
        [DisplayName("Origin Postalcode")]
        public string originpostalcode { get; set; }

        [Required(ErrorMessage = "Destination postalcode is required")]
        [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]", ErrorMessage = "Please enter a valid Postalcode")]
        [DisplayName("Destination Postalcode")]
        public string destinationpostalcode { get; set; }

        [Required(ErrorMessage = "Parcel weight is required")]
        [RegularExpression(@"^[0-9]([.,][0-9]{1,3})?$", ErrorMessage = "Please enter a valid weight")]
        [DisplayName("Parcel weight")]
        public decimal parcelweight { get; set; }

    }
}