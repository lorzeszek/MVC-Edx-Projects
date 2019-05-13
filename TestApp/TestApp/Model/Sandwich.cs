using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Model
{
    public class Sandwich : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
