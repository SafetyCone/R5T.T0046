using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0046
{
    [HasXMarker, DataTypeMarker]
    public interface IHasAuthor
    {
        Author Author { get; }
    }
}
