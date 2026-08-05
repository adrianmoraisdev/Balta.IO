using System;

namespace MaoNaMassa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Sample Article", "https://example.com/article"));
            articles.Add(new Article("Sample Article2", "https://example.com/article2"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("------------------------------------");
            }

            var courses = new List<Course>();
            var coursesOOP = new Course("Fundamentos", "https://example.com/fundamentos");
            var coursesCsharp = new Course("CSharp", "https://example.com/csharp");
            var coursesAspNet = new Course("ASP.NET", "https://example.com/aspnet");

            courses.Add(coursesOOP);
            courses.Add(coursesCsharp);
            courses.Add(coursesAspNet);


            var carrerItems = new List<CarrerItem>();
            var carrer = new Carrer("Especialista .NET", "https://example.com/especialista-dotnet");
            var carrerItem = new CarrerItem(1, "Fundamentos", "Introdução aos fundamentos", coursesOOP);
            carrer.Items.Add(carrerItem);

            foreach (var item in carrer.Items)
            {
                Console.WriteLine(item.Title);
                foreach (var items in carrer.Items)
                {
                    Console.WriteLine($" - {items.Title} ({items.Course.Title})");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }

            }
        }
    }
}