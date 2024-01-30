using System;


namespace R5T.T0046
{
    public class AuthorContextOperations : IAuthorContextOperations
    {
        #region Infrastructure

        public static IAuthorContextOperations Instance { get; } = new AuthorContextOperations();


        private AuthorContextOperations()
        {
        }

        #endregion
    }
}
