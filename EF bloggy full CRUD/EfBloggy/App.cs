using System;
using System.Collections.Generic;
using System.Text;

namespace EfBloggy
{
    public class App
    {
        static BlogContext context = new BlogContext();

        public void Run()
        {
            //Functions.ClearDatabase();                //Körs en gång sedan kommenteras ut
            Functions.AddSomeTitles();                //Körs en gång sedan kommenteras ut
            MainMenu();
        }
        public void MainMenu()
        {
            Header("Huvudmeny");

            ShowAllBlogPostsBrief();

            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("a) Go to main menu");
            Console.WriteLine("b) Create blogpost");
            Console.WriteLine("c) Update en blogpost");
            Console.WriteLine("d) Delete en blogpost");
            ConsoleKey command = Console.ReadKey(true).Key;

            if (command == ConsoleKey.A)
                MainMenu();

            if (command == ConsoleKey.B)
                PageCreatePost();
            if (command == ConsoleKey.B)
                PageUpdatePost();
            if (command == ConsoleKey.B)
                PageDeletePost();
        }

        private void PageDeletePost()
        {
            Header("Delete");

            ShowAllBlogPostsBrief();

            Write("\nDo you want to delete something?");

            int blogPostId = int.Parse(Console.ReadLine());

            var blogPost = context.BlogPosts.Find(blogPostId);


            context.BlogPosts.Remove(blogPost);
            context.SaveChanges();

            Write("Deleted.");
            Console.ReadKey();
            MainMenu();
        }

        private void PageCreatePost()
        {
            Header("Create");


            Write("\nCreate my Title: ");

            string newTitle = Console.ReadLine();

            Write("\nCreate my Author: ");

            string newAuthor = Console.ReadLine();
            BlogPost blogPost = new BlogPost();
            blogPost.Title = newTitle;
            blogPost.Author = newAuthor;

            context.BlogPosts.Add(blogPost);
            context.SaveChanges();

            Write("BloggPost Created.");
            Console.ReadKey();
            MainMenu();
        }

        private void PageUpdatePost()
        {
            Header("Uppdatera");

            ShowAllBlogPostsBrief();

            Write("\nVilken bloggpost vill du uppdatera? ");

            int blogPostId = int.Parse(Console.ReadLine());

            var blogPost = context.BlogPosts.Find(blogPostId);

            WriteLine("Den nuvarande titeln är: " + blogPost.Title);

            Write("Skriv in ny titel: ");

            string newTitle = Console.ReadLine();

            blogPost.Title = newTitle;

            context.BlogPosts.Update(blogPost);
            context.SaveChanges();

            Write("Bloggposten uppdaterad.");
            Console.ReadKey();
            MainMenu();
        }

        private void ShowAllBlogPostsBrief()
        {
            foreach (var x in context.BlogPosts)
            {
                WriteLine(x.Id.ToString().PadRight(5) + x.Title.PadRight(30) + x.Author.PadRight(20));
            }
        }

        private void Header(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine();
        }
        private void WriteLine(string text = "")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        private void Write(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }
    }

}
