using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IStoryEvent<TID> : JB2.Common.IIDNamePair<TID, string>
        where TID : IComparable
    {
        event Action<IStoryEvent<TID>, IEnumerable<ICharacter<TID>>, DateTime> EventCompleted;
        IEmotion Emotion { get; set; }
        string Description { get; set; }
        
        IEnumerable<ICharacter<TID>> GetAffectedCharacters();


    }
}
