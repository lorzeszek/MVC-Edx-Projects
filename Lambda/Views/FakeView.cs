namespace Lambda.Views
{
    public class FakeHtmlHelper<TModel> {}
    public class FakeViewPage<TModel>
    {
        public FakeHtmlHelper<TModel> HtmlHelper { get; }
        public FakeViewPage() 
        {
                HtmlHelper = new FakeHtmlHelper<TModel>();
        }
    }
}