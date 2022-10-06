using System;

using R5T.T0142;


namespace R5T.T0046
{
    /// <summary>
    /// Useful for the Git required author.
    /// </summary>
    [DataTypeMarker]
    public interface IAuthor
    {
        string Name { get; set; }
        string EmailAddress { get; set; }
    }
}