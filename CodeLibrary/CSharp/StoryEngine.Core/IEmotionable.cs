using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public interface IEmotionable 
    {
        IEmotion GetCurrentEmotion();
        IEmotion GetPreviousEmotion();


        IEnumerable<IEmotion> GetEmotionHistory();

    }
}
