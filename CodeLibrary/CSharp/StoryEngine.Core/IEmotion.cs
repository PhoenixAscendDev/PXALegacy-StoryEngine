using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.Engine.Storybook
{
    public interface IEmotion : JB2.Common.IIDNamePair<int, string>
    {
        int ToIntValue();
        JB2.Common.PADTrait ToPADTrait();
    }
}
