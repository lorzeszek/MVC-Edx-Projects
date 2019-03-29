using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;

namespace Microsoft.AspNetCore.Mvc.Rendering 
{
    public static class MyHtmlHelperExtensions 
    {
        public static IHtmlContent ColorfulHeading(this IHtmlHelper htmlHelper, int level, string color, string content) 
        {
            level = level < 1 ? 1 : level;
            level = level > 6 ? 6 : level;
            var tagName = $"h{level}";
            var tagBuilder = new TagBuilder(tagName);
            tagBuilder.Attributes.Add("style", $"color:{color ?? "green"}");
            tagBuilder.InnerHtml.Append(content ?? string.Empty);
            return tagBuilder;
        }
        public static IHtmlContent FakeTextBoxFor<TModel, TResult>(this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression) {
            var body = expression.Body as MemberExpression;
            var propertyName = body.Member.Name.ToLower(); // keep lower case
            var tagBuilder = new TagBuilder("input");
            tagBuilder.Attributes.Add("type", "text"); // can be omitted
            tagBuilder.Attributes.Add("name", propertyName); // key purpose 1: for name-value pair
            tagBuilder.Attributes.Add("id", propertyName); // key purpose 2: for client JavaScript and CSS
            return tagBuilder;
        }

        public static IHtmlContent Table(this IHtmlHelper htmlHelper, string[] columnNames, string[,] content) {
            var tableBuilder = new TagBuilder("table");
            tableBuilder.Attributes.Add("border", "1");
            var headerBuilder = new TagBuilder("tr");
            foreach (var cn in columnNames) {
                var headerCellBuilder = new TagBuilder("th");
                headerCellBuilder.InnerHtml.Append(cn);
                headerBuilder.InnerHtml.AppendHtml(headerCellBuilder); // zamkniecie komorki headera
            }

            tableBuilder.InnerHtml.AppendHtml(headerBuilder);  //zamkniecie wiersza 
            int colCount = columnNames.Length;
            int rowCount = content.Length / colCount;
            for (int r = 0; r < rowCount; r++) {
                var rowBuilder = new TagBuilder("tr");
                for (int c = 0; c < colCount; c++) {
                    var cellBuilder = new TagBuilder("td");
                    cellBuilder.InnerHtml.Append(content[r, c]);
                    rowBuilder.InnerHtml.AppendHtml(cellBuilder); // zamkniecie komorki 
                }
                tableBuilder.InnerHtml.AppendHtml(rowBuilder); //zamkniecie wiersza 
            }

            return tableBuilder;
        }
    }
}