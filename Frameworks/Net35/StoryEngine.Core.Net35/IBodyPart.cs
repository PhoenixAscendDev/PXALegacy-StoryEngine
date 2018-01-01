using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IBodyPart<TID> : JB2.Common.IIDNamePair<TID,string>
        where TID : IComparable
    {
    }
}
