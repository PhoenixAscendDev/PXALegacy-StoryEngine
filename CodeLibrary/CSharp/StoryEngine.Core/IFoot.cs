using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.Engine.Storybook
{
    public interface IFoot<TID> : IBodyPart<TID>
        where TID : IComparable
    {

    }
}
