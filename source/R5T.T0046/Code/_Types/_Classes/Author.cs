using System;

using R5T.T0142;


namespace R5T.T0046
{
    [DataTypeMarker]
    public class Author : IAuthor
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}