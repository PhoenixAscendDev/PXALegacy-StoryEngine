using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Common;
using JB2.Engine.Storybook;

namespace JB2.Storybook.MilkyWay
{
    public  class Human : Character,ISpecies<string>
    {
        #region Fields
        
        protected List<IEmotion> _emotions;
        protected List<IRelationship<string>> _relationships;

        #endregion Fields

        public Human() : base()
        {
            _bodyparts.Add(Engine.Storybook.Enum.BodyPartType.Head, new Head[1] { new Head() });
            _bodyparts.Add(Engine.Storybook.Enum.BodyPartType.Hand, new Hand[2] { new Hand(5), new Hand(5) });
            _bodyparts.Add(Engine.Storybook.Enum.BodyPartType.Foot, new Foot[2] { new Foot(5), new Foot(5) });
        }

        public override IEnumerable<ICharacter<string>> GetChildren()
        {
            return _children;
        }

        public override IEnumerable<IEmotion> GetEmotionHistory()
        {
            return _emotions;
        }

        public override IEmotion GetPreviousEmotion()
        {
            return _emotions.Last();
        }

        public override IEnumerable<IRelationship<string>> GetRelationships()
        {
            return _relationships;
        }
    }
}
