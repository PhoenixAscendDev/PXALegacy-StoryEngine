using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public interface ICharacterAttribute : ICharacterAttribute<short>
    {

    }
    public interface ICharacterAttribute<TType> : ICharacterAttribute<short,TType>
    {

    }
    public interface ICharacterAttribute<TNumber,TType>
    {
        TNumber GetValue();
        TNumber GetMultiplayer();

        TType GetAttributeType();

        IEnumerable<ICharacterAttribute<TNumber>> GetChildren();

    }
}
