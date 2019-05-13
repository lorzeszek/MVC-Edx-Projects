using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Model
{
    public class Coffee : IProduct
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "wymagane")]
        [MaxLength(10)]
        public string Name { get; set; }

        public bool HasSugar { get; set; }
    }
}
