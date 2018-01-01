using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IEmotion : JB2.Common.IIDNamePair<int, string>
    {
        int ToIntValue();
        JB2.Common.PADTrait ToPADTrait();
    }
}
