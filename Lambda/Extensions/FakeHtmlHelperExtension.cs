using System;
using System.Linq.Expressions;
using Lambda.Views;

namespace Lambda.Extensions
{
    public static class FakeHtmlHelperExtension
    {
        public static string GetName<TModel, TResult>(this FakeHtmlHelper<TModel> target, Expression<Func<TModel, TResult>> expression) 
        {
            var body = expression.Body as MemberExpression;
            return body.Member.Name;
        }
    }
}