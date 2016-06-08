using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public interface IObject<TKind,TRNG, TID,TTag> : JB2.Common.IObject<TKind,TID,TTag>
        where TID : IComparable
    {
       TRNG RandomNumber { get; set; }

       JB2.Common.JB2Color PrimaryColor { get; set; }

       TRNG GetRandomNumber();

    }
}
