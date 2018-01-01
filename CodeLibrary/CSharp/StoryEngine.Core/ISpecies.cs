using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.Storybook
{
    public interface ISpecies : ICharacter<string>
    {

    }

    public interface ISpecies<TID> : ICharacter<TID>
        where TID : IComparable
    {

    }
    
}
