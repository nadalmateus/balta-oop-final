namespace balta
{
    using System.Net.Mime;
    using Balta.ContentContext;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var course = new Course();
            course.Level = Balta.ContentContext.Enums.EContentLevel.Beginner;

            foreach (var item in course.Modules)
            {

            }
        }
    }
}