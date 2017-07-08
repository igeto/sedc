using System;
using System.Collections.Generic;
using BookEntitiesG1;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessG1
{
    public class AuthorRepository : IAuthorRepository
    {
        private string connectionString;

        public AuthorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Author CreateAuthor(string name, DateTime? dateOfBirth = null, DateTime? dateOfDeath = null)
        {
            if (GetAuthorsByName(name).Any(a => a.Name == name))
            {
                throw new ArgumentException($"Author with name {name} already exists");
            }

            int authorId = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.Transaction = transaction;

                        cmd.CommandText = "insert into Authors (Name, DateOfBirth, DateOfDeath) values (@authorName, @dateOfBirth, @dateOfDeath)";
                        cmd.Parameters.AddWithValue("@authorName", name);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@dateOfDeath", dateOfDeath ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "select @@identity";
                        authorId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    transaction.Commit();
                }
            }
            return GetAuthorById(authorId);
        }

        public bool DeleteAuthor(Author author)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "delete from Authors where ID=@id";
                    cmd.Parameters.AddWithValue("@id", author.Id);

                    int rowCount = cmd.ExecuteNonQuery();
                    return rowCount == 1;
                }
            }
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            var authors = new List<Author>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "select ID, Name, DateOfBirth, DateOfDeath from Authors";

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            authors.Add(GetAuthorFromDataReader(dr));
                        }
                    }
                }
            }

            return authors;
        }

        public Author GetAuthorById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "select ID, Name, DateOfBirth, DateOfDeath from Authors where ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return GetAuthorFromDataReader(dr);
                        }
                        throw new InvalidOperationException($"Author with ID {id} not found");
                    }
                }
            }

        }

        public IEnumerable<Author> GetAuthorsByName(string nameFragment)
        {
            var authors = new List<Author>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "getAuthors";
                    cmd.Parameters.AddWithValue("@authorName", nameFragment);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            authors.Add(GetAuthorFromDataReader(dr));
                        }
                    }
                }
            }
            return authors;
        }

        public Author UpdateAuthor(Author author)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "update Authors set Name = @name, DateOfBirth = @dob, DateOfDeath = @dod where ID=@id";
                    cmd.Parameters.AddWithValue("@id", author.Id);
                    cmd.Parameters.AddWithValue("@name", author.Name);
                    cmd.Parameters.AddWithValue("@dob", author.BirthDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@dod", author.DeathDate ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            return GetAuthorById(author.Id);
        }

        private Author GetAuthorFromDataReader(SqlDataReader dr)
        {
            int authorId = (int)dr["ID"];
            string name = (string)dr["Name"];
            DateTime? dob = dr.IsDBNull(2) ? (DateTime?)null : (DateTime)dr["DateOfBirth"];
            DateTime? dod = dr.IsDBNull(3) ? (DateTime?)null : (DateTime)dr["DateOfDeath"];

            var author = new Author
            {
                Id = authorId,
                Name = name,
                BirthDate = dob,
                DeathDate = dod
            };
            return author;
        }
    }
}
