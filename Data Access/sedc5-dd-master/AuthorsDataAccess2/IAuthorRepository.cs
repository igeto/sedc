using AuthorEntities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsDataAccess2
{
    public interface IAuthorRepository
    {
        Author AddAuthor(string name, DateTime? dateOfBirth = null, DateTime? datOfDeath = null);
        Author UpdateAuthor(Author author);
        bool DeleteAuthor(int authorId);
        IEnumerable<Author> GetAllAuthors();
        IEnumerable<Author> GetAuthorsByName(string nameFragment);
        Author GetAuthorById(int authorId);
    }
}
