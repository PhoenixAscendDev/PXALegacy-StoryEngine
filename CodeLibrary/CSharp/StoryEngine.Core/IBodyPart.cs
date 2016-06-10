using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public interface IBodyPart<TID> : JB2.Common.IIDNamePair<TID,string>
        where TID : IComparable
    {
    }
}
