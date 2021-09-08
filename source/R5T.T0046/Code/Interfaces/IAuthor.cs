using System;


namespace R5T.T0046
{
    /// <summary>
    /// Useful for the Git required author.
    /// </summary>
    public interface IAuthor
    {
        string Name { get; set; }
        string EmailAddress { get; set; }
    }
}