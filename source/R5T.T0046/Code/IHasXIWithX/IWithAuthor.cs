using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0046
{
    [WithXMarker, DataTypeMarker]
    public interface IWithAuthor :
        IHasAuthor
    {
        new Author Author { get; set; }
    }
}
