using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public interface ISpecies<TID, TName, TAttributeIndex, TAttribute, TKind, TTag, TRng> : ICharacter<TID, TName, TAttributeIndex, TAttribute, TKind, TTag, TRng> 
        where TID : IComparable
        where TName : IComparable
        where TRng : IComparable
        where TKind : IComparable
        where TAttribute : ICharacterAttribute<int>
    {

    }
}
