using NyaBloggen.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NyaBloggen
{
    class App
    {
        public void Run()
        {
            {
                Pagemenu();
            }
           
        }

        private void ReadAndLeaveComments()
        {
            Console.Clear();
            Console.WriteLine("Read And Leave Comments");

            var dataAccess = new DataAccess();

            ShowAllBlogPosts();
            Console.WriteLine();

            Console.WriteLine("What do you wat to do?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("[A] leave a comment");
            Console.WriteLine("[B] show comments");
            Console.WriteLine("[C] Go to mainmenu");
            ConsoleKey x = Console.ReadKey().Key;

            Console.WriteLine();
            Console.WriteLine();

            switch (x)
            {               
                case ConsoleKey.D: PageLeaveAComment(); break;
                case ConsoleKey.E: PageShowComment(); break;
                case ConsoleKey.C: Pagemenu(); break;

            }
        }

        private void AuthorsAndTitle()
        {
            Console.Clear();
            Console.WriteLine("Authors And Title");

            var dataAccess = new DataAccess();

            ShowAllBlogPosts();
            Console.WriteLine();

            Console.WriteLine("What do you wat to do?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("[A] Update title");
            Console.WriteLine("[B] Update author");
            Console.WriteLine("[C] Go to mainmenu");

            ConsoleKey x = Console.ReadKey().Key;

            switch (x)
            {                
                case ConsoleKey.A: PageUpdateTitle(); break;
                case ConsoleKey.B: PageUpdateAuthor(); break;
                case ConsoleKey.C: Pagemenu(); break;
            }
        }

        private void Pagemenu()
        {
            Console.WriteLine("Welcome to the BlogBlog");
            Console.WriteLine("Välj [1 för Authors and Titles eller 2 för Read and leave comments");
            int menuChoice = int.Parse(Console.ReadLine());

            while (true)
            {
                if (menuChoice == 1)
                    AuthorsAndTitle();
                else if (menuChoice == 2)
                    ReadAndLeaveComments();
                else
                    Console.WriteLine("Felaktigt val, försök igen");
            }



        }
        //{
        //    Console.Clear();
        //    Console.WriteLine("Welcome to the Mainmenu");

        //    var dataAccess = new DataAccess();

        //    ShowAllBlogPosts();
        //    Console.WriteLine();

        //    Console.WriteLine("What do you wat to do?");
        //    Console.WriteLine("-------------------------------");
        //    Console.WriteLine("[A] Go to mainmenu");
        //    Console.WriteLine("[B] Update title");
        //    Console.WriteLine("[C] Update author");
        //    Console.WriteLine("[D] leave a comment");
        //    Console.WriteLine("[E] show comments");
        //    ConsoleKey x = Console.ReadKey().Key;

        //    switch (x)
        //    {
        //        case ConsoleKey.G: Pagemenu(); break;
        //        case ConsoleKey.B: PageUpdateTitle(); break;
        //        case ConsoleKey.C: PageUpdateAuthor(); break;
        //        case ConsoleKey.D: PageLeaveAComment(); break;
        //        case ConsoleKey.E: PageShowComment(); break;


        //    }
        //}

        private void PageShowComment()
        {
            Console.Clear();
            var dataAccess = new DataAccess();


            Console.WriteLine("Press enter to see comments: ");


           List<PostComment> result = dataAccess.ShowAllComments();

            foreach (var item in result)
            {
                Console.WriteLine(item.Comments);
            }

            Console.ReadKey();
            Pagemenu();
        }

        private void PageLeaveAComment()
        {
            Console.Clear();
            var dataAccess = new DataAccess();


            Console.WriteLine("Leave a comment: ");
            string userComment = Console.ReadLine();
            Console.WriteLine("Enter your nick: ");
            string userName = Console.ReadLine();

            dataAccess.PostComment(userComment, userName);

            Console.ReadKey();
            Pagemenu();
        }


        private void PageUpdateAuthor()
        {
            Console.Clear();
            var dataAccess = new DataAccess();




            ShowAllBlogPosts();



            Console.WriteLine("Choose author to update: ");


            int userInput = int.Parse(Console.ReadLine());

            BlogPost post = dataAccess.GetBlogPostById(userInput);


            Console.WriteLine("Type a new author: ");


            string authorInput = Console.ReadLine();



            post.Author = authorInput;

            dataAccess.UpdateAuthor(post);

            Console.WriteLine("The author has been updated");
            Console.ReadKey();
            Pagemenu();

        }

        private void PageUpdateTitle()
        {
            Console.Clear();
            var dataAccess = new DataAccess();




            ShowAllBlogPosts();



            Console.WriteLine("Choose post to update: ");


            int userInput = int.Parse(Console.ReadLine());

            BlogPost post = dataAccess.GetBlogPostById(userInput);

            Console.WriteLine("Skriv in en ny titel: ");


            string titelInput = Console.ReadLine();



            post.Title = titelInput;

            dataAccess.Updateblogpost(post);

            Console.WriteLine("Title is updated");
            Console.ReadKey();
            Pagemenu();

        }

        private void ShowAllBlogPosts()
        {
            var dataAccess = new DataAccess();

            List<BlogPost> allposts = dataAccess.GetAllBlogPosts();

            Console.WriteLine();
            Console.WriteLine("ID".PadRight(5) + "Author".PadRight(20) + "Title".PadRight(20));
            Console.WriteLine("-------------------------------------------------");

            foreach (var item in allposts)
            {

                Console.WriteLine(item.ID.ToString().PadRight(5) + item.Author.PadRight(20) + item.Title.PadRight(20));
            }
        }
    }
}
