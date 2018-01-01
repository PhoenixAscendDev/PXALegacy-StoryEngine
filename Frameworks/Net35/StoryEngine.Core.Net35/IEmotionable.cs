using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IEmotionable 
    {
        IEmotion GetCurrentEmotion();
        IEmotion GetPreviousEmotion();


        IEnumerable<IEmotion> GetEmotionHistory();

    }
}
