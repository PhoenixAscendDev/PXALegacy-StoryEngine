using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.Engine.Storybook
{

    public interface ICharacter : ICharacter<string>
    {

    }

    public interface ICharacter<TID> : JB2.Common.IPerson<TID>, IEmotionable
        where TID : IComparable            
    {
        IDictionary<string, ICharacterAttribute> BaseAttributes { get; set; }

        Body<TID> Body { get; set; }
        IPersonalityTraits PersonalityTrait { get; set; }

        IEnumerable<IBodyPart<TID>> GetBodyParts();

        IEnumerable<IRelationship<TID>> GetRelationships();

        IEnumerable<ICharacter<TID>> GetChildren();

        string CharacterClass { get; set; }
    }
}
