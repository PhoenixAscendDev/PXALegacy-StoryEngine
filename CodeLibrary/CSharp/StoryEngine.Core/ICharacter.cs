using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public interface ICharacter<TID, TName, TAttributeIndex, TAttribute, TKind, TTag, TRng> : IObject<TKind, TRng, TID, TTag>, JB2.Common.IPerson<TID>
        where TID : IComparable
        where TName : IComparable
        where TRng : IComparable
        where TKind : IComparable
        where TAttribute : ICharacterAttribute<int>
    {
        IEmotion CurrentEmotion { get; set; }
        IDictionary<TAttributeIndex, TAttribute> BaseAttributes { get; set; }
        IEnumerable<ICharacter<TID, TName, TAttributeIndex, TAttribute, TKind, TTag, TRng>> Children { get; set; }

        IEnumerable<IFoot<TID>> Feet { get; set; }
        IEnumerable<IHand<TID>> Hands { get; set; }
        IEnumerable<IHead<TID>> Heads { get; set; }

        IEnumerable<IBodyPart<TID>> GetBodyParts();
    }
}
