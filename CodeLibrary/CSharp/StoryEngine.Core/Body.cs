using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.Storybook
{
    public struct Body<TID>
        where TID: IComparable
    {
        public IEnumerable<IFoot<TID>> Feet { get; set; }
        public IEnumerable<IHand<TID>> Hands { get; set; }
        public IEnumerable<IHead<TID>> Heads { get; set; }
    }
}
