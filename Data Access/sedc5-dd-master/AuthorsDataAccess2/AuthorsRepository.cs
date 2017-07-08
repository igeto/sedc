using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorEntities2;
using System.Data.SqlClient;

namespace AuthorsDataAccess2
{
    public class AuthorsRepository : IAuthorRepository
    {
        private string connectionString;

        public AuthorsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Author AddAuthor(string name, DateTime? dateOfBirth, DateTime? datOfDeath)
        {
            if (GetAuthorsByName(name).Any(a => a.Name == name))
            {
                throw new ArgumentException("name already exists");
            }
            var authorId = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandText = "insert into Authors (Name, DateOfBirth, DateOfDeath) values(@authorName, @dob, @dod";
                        command.Parameters.AddWithValue("@authorName", name);
                        command.Parameters.AddWithValue("@dob", dateOfBirth ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@dod", datOfDeath ?? (object)DBNull.Value);

                        command.ExecuteNonQuery();
                        command.CommandText = "select IDENT_CURRENT('Authors')";
                        authorId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    transaction.Commit();
                }
                
            }
            return GetAuthorById(authorId);
        }

        public bool DeleteAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            List<Author> result = new List<Author>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select ID, Name, DateOfBirth, DateOfDeath from Authors";

                    using (var repo = command.ExecuteReader())
                    {
                        while (repo.Read())
                        {
                            Author author = LoadAuthorForReader(repo);

                            result.Add(author);
                        }
                    }

                }

            }
            return result;
        }

        public Author GetAuthorById(int authorId)
        {
            Author result = new Author();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select ID, Name, DateOfBirth, DateOfDeath from Authors where ID =@ID";
                    command.Parameters.AddWithValue("@ID", authorId);

                    using (var repo = command.ExecuteReader())
                    {
                        Author author = null;
                        if (repo.Read())
                        {
                            author = LoadAuthorForReader(repo);
                        }
                        return author;

                    }

                }

            }
            
        }

        public IEnumerable<Author> GetAuthorsByName(string nameFragment)
        {
            List<Author> result = new List<Author>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "getAuthors";
                    command.Parameters.AddWithValue("@authorName", nameFragment);

                    using (var repo = command.ExecuteReader())
                    {
                        while (repo.Read())
                        {
                            result.Add(LoadAuthorForReader(repo));
                        }
                    }

                }

            }
            return result;
        }

        public Author UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }
        private Author LoadAuthorForReader(SqlDataReader dr)
        {
            int authorID = (int)dr["ID"];
            string authorName = (string)dr["Name"];
            DateTime? dob = dr.IsDBNull(2) ? (DateTime?)null : (DateTime)dr["DateOfBirth"];
            DateTime? dod = dr.IsDBNull(3) ? (DateTime?)null : (DateTime)dr["DateOfDeath"];

            Author author = new Author
            {
                Id = authorID,
                Name = authorName,
                BirthDay = dob,
                DeathDay = dod
            };
            return author;
        }

    }
}
