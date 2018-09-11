using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using NyaBloggen.Domain;

namespace NyaBloggen
{
    class DataAccess
    {
        public List<PostComment> ShowAllComments()
        {
            string sql = @"select * from PostComment";
            string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                var result = new List<PostComment>();

                while (reader.Read())
                {
                    PostComment kommentar = new PostComment();
                    int Id = reader.GetSqlInt32(0).Value;
                    string name = reader.GetSqlString(2).Value;
                    string comments = reader.GetSqlString(1).Value;
                    kommentar.ID = Id;
                    kommentar.nickName = name;
                    kommentar.Comments = comments;

                    result.Add(kommentar);

                }
                return result;



            }
        }

        public List<BlogPost> GetAllBlogPosts()
        {


            string sql = "Select ID, Title, Author From BlogPost";
            string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();



                var result = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost();

                    int Id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string author = reader.GetSqlString(2).Value;

                    bp.ID = Id;
                    bp.Author = author;
                    bp.Title = title;

                    result.Add(bp);

                }
                return result;
            }




        }

        public void PostComment(string comments, string name)
        {

            string sql = "insert into Postcomment (comments, name) values (@comments,@name)";
            string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                connection.Open();
                command.Parameters.Add(new SqlParameter("comments", comments));
                command.Parameters.Add(new SqlParameter("name", name));
                command.ExecuteNonQuery();
            }

        }

        public BlogPost GetBlogPostById(int blogpostid)
        {
            string sql = "Select ID, Title, Author From BlogPost where id=@kalle";
            string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg";
            
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                connection.Open();
                command.Parameters.Add(new SqlParameter("Kalle", blogpostid));
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var bp = new BlogPost();

                int Id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string author = reader.GetSqlString(2).Value;

                bp.ID = Id;
                bp.Author = author;
                bp.Title = title;
                return bp;



            }

        }

        internal void Updateblogpost(BlogPost post)
        {
            string sql = "update BlogPost set Title = @Title where ID = @ID";
            string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("Title", post.Title));

                command.Parameters.Add(new SqlParameter("ID", post.ID));

                command.ExecuteNonQuery();
            }

        }
        internal void UpdateAuthor(BlogPost post)
        {
            string sql = "update BlogPost set Author = @Author where ID = @ID";
            string conString = @"Server=(localdb)\mssqllocaldb;Database=Blogg";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("Author", post.Author));

                command.Parameters.Add(new SqlParameter("ID", post.ID));

                command.ExecuteNonQuery();
            }
        }
    }
}



