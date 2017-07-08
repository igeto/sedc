using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorEntities2;
using AuthorsDataAccess2;

namespace AuthorsBusinessRules2
{
    public class AuthorProvider : IAuthorProvider
    {
        private IAuthorRepository authorRepo;
        public AuthorProvider(IAuthorRepository authorRepo)
        {

        }
        public Author ChangeName(Author author, string newName)
        {
            var oldName = author.Name;
            try
            {
                author.Name = newName;
                authorRepo.UpdateAuthor(author);
            }
            catch
            {

                author.Name = oldName;
                throw;
            }
            return author;
        }

        public Author CreateAuthor(string name, DateTime? birthDate = default(DateTime?), DateTime? deathDate = default(DateTime?))
        {
            return authorRepo.AddAuthor(name, birthDate, deathDate);
        }

        public bool DeleteAuthor(Author author)
        {
            var isDeleted = true;
            try
            {
                authorRepo.DeleteAuthor(author.Id);
            }
            catch
            {

                isDeleted = false;
                throw;
            }
            return isDeleted;
        }

        public IEnumerable<Author> GetAuthors(string nameFragment = "")
        {
            if (string.IsNullOrEmpty(nameFragment))
            {
                return authorRepo.GetAllAuthors();
            }
            else
            {
                return authorRepo.GetAuthorsByName(nameFragment);
            }
        }

        public Author RecordDeath(Author author, DateTime deathDate)
        {
            var oldDeathDay = author.DeathDay;
            try
            {
                author.DeathDay = deathDate;
                authorRepo.UpdateAuthor(author);
            }
            catch
            {

                author.DeathDay = oldDeathDay;
                throw;
            }            
            return author;
        }
    }
}
