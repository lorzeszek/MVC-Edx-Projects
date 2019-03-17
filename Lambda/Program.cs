using System;
using Lambda.Extensions;
using Lambda.Models;
using Lambda.Views;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new FakeViewPage<Person>();
            var propertyName = view.HtmlHelper.GetName(p => p.ID);
            Console.WriteLine(propertyName);
            propertyName = view.HtmlHelper.GetName(p => p.Name);
            Console.WriteLine(propertyName);
            propertyName = view.HtmlHelper.GetName(p => p.Age);
            Console.WriteLine(propertyName);
        }
    }
}
