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

        [Column(TypeName = "char(3)")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "char(52)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Continent { get; set; }

        [Required]
        [Column(TypeName = "char(26)")]
        public string Region { get; set; }

        [Required]
        [Column(TypeName = "char(26)")]
        public string SurfaceArea { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Population { get; set; }

        [Required]
        [Column(TypeName = "char(45)")]
        public string LocalName { get; set; }

        [Required]
        [Column(TypeName = "char(45)")]
        public string GovernmentForm { get; set; }

        [Column(TypeName = "char(2)")]
        public string Code2 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string NationalFlag { get; set; }

        [InverseProperty("CountryCodeNavigation")]
        public virtual ICollection<City> City { get; set; }
    }
}
