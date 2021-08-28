namespace Balta.ContentContext
{
    using NotificationContext;
    using System.Collections.Generic;

    public class Article : Content
    {
        public Article(string title, string url) : base(title, url)
        {
        }
    }
}