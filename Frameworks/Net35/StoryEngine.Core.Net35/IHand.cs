using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IHand<TID> : IBodyPart<TID>
        where TID : IComparable
    {
    }
}
