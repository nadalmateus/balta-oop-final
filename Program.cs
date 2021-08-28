namespace balta
{
    using Balta.ContentContext;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Article> articles = new();
            articles.Add(new Article("Artigo OOP", "orientação a objetos"));
            articles.Add(new Article("Artigo C#", "orientação a objetos"));
            articles.Add(new Article("Artigo .NET", "orientação a objetos"));


            // foreach (Article article in articles)
            // {
            //     System.Console.WriteLine(article.Id);
            //     System.Console.WriteLine(article.Title);
            //     System.Console.WriteLine(article.Url);
            // }

            List<Course> courses = new();
            Course courseCSharp = new("Fundamentos C#", "OOP");
            Course courseDotNet = new("Fundamentos .NET", "OOP");
            courses.Add(courseCSharp);


            List<Career> careers = new();
            Career careerDotnet = new("Desenvolvedor", "OOP");
            CareerItem careerItem = new(1, "C#", "OOP", courseCSharp);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (Career career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (CareerItem item in career.Items.OrderByDescending(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
    }
}