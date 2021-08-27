namespace balta
{
    using System.Collections.Generic;
    using System.Linq;
    using Balta.ContentContext;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            articles.Add(new Article("Artigo OOP", "orientação a objetos"));
            articles.Add(new Article("Artigo C#", "orientação a objetos"));
            articles.Add(new Article("Artigo .NET", "orientação a objetos"));


            // foreach (Article article in articles)
            // {
            //     System.Console.WriteLine(article.Id);
            //     System.Console.WriteLine(article.Title);
            //     System.Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var courseCSharp = new Course("Fundamentos C#", "OOP");
            var courseDotNet = new Course("Fundamentos .NET", "OOP");
            courses.Add(courseCSharp);


            var careers = new List<Career>();
            var careerDotnet = new Career("Desenvolvedor", "OOP");
            var careerItem = new CareerItem(1, "C#", "OOP", courseCSharp);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                System.Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderByDescending(x => x.Order))
                {
                    System.Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
    }
}