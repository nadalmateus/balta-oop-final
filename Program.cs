using csharp.ContextContent;

var articles = new List<Article>();
articles.Add(new Article("C#", "dot.net"));
articles.Add(new Article("F#", "dot.net"));
articles.Add(new Article("Java", "java.net"));



foreach (var article in articles)
{
    System.Console.WriteLine(article.Id);
    System.Console.WriteLine(article.Title);
    System.Console.WriteLine(article.Url);

}
