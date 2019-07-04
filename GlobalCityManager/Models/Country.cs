using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalCityManager.Models
{
    [Table("country")]
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        [StringLength(3, MinimumLength = 2)]
        [Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "char(3)")]
        public string Code { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Nazwa")]
        [Column(TypeName = "char(52)")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Continent must be selected")]
        [Column(TypeName = "varchar(30)")]
        public string Continent { get; set; }
        //public IEnumerable<SelectListItem> ContinentList { get; set; }

        //[Required(ErrorMessage = "Region must be selected")]        
        [Column(TypeName = "char(26)")]
        public string Region { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "single")]
        public Single SurfaceArea { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "int")]
        public int? Population { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "char(45)")]
        public string LocalName { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "char(45)")]
        public string GovernmentForm { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "char(2)")]
        public string Code2 { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [Column(TypeName = "varchar(200)")]
        public string NationalFlag { get; set; }

        //[Required(ErrorMessage = "Field cannot be empty")]
        [InverseProperty("CountryCodeNavigation")]
        public virtual ICollection<City> City { get; set; }
    }
}
