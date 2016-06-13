using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Common;

namespace JB2.Engine.Storybook
{
    public interface IRelationship<TID>: JB2.Common.IUpdateable, JB2.Common.IIDProp<TID>, IEmotionable
    {
        IIDProp<TID>  Character1 { get; set; }
        IIDProp<TID>  Character2 { get; set; }

        string Description { get; set; }
    }
}
