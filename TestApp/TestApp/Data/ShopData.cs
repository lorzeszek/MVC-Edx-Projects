using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    public static class ShopData
    {
        public static Dictionary<int, string> coffees = new Dictionary<int, string>() { { 1, "cofee1" }, { 2, "cofee2" }, { 3, "cofee3" } };
        public static Dictionary<int, string> coctails = new Dictionary<int, string>() { { 1, "coctail1" }, { 2, "coctail2" }, { 3, "coctail3" } };
        public static Dictionary<int, string> sandwitches = new Dictionary<int, string>() { { 1, "sandwitch1" }, { 2, "sandwitch2" }, { 3, "sandwitch3" } };

    }
}
