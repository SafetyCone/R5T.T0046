using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0241;


namespace R5T.T0046
{
    [ContextOperationsMarker, ValuesMarker]
    public partial interface IAuthorContextOperations : IValuesMarker
    {
        public Func<TContext, Task> Set_Author<TContext>(
            string name,
            string emailAddress)
            where TContext : IWithAuthor
        {
            var author = new Author
            {
                Name = name,
                EmailAddress = emailAddress,
            };

            return this.Set_Author<TContext>(author);
        }

        public Func<TContext, Task> Set_Author<TContext>(
            Author author)
            where TContext : IWithAuthor
        {
            return context =>
            {
                context.Author = author;

                return Task.CompletedTask;
            };
        }
    }
}
