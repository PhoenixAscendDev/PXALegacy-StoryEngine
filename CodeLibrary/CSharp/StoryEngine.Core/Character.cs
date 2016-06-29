using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JB2.Common;

namespace JB2.Engine.Storybook
{
    public abstract class Character : ICharacter<string>
    {
        #region Fields
        protected IDictionary<string, ICharacterAttribute> _attributes;
        protected IEnumerable<ICharacter<string>> _children;
        protected IEmotion _emotion;
        protected Name _name;
        protected IDictionary<Enum.BodyPartType, IEnumerable<IBodyPart<string>>> _bodyparts;
        protected IPersonalityTraits _pTraits;
        protected string _id;
        protected JB2Color _color;
        protected int _rng;
        protected List<string> _tags;
        protected string _kind;
        protected string _class;


        public virtual Body<string> Body
        {
            get
            {
                var result = new Body<string>();

                result.Feet = (IEnumerable<IFoot<string>>)_bodyparts[Enum.BodyPartType.Foot];
                result.Hands = (IEnumerable<IHand<string>>)_bodyparts[Enum.BodyPartType.Hand];
                result.Heads = (IEnumerable<IHead<string>>)_bodyparts[Enum.BodyPartType.Head];

                return result;
            }
            set
            {
                if (_bodyparts == null)
                    _bodyparts = new Dictionary<Enum.BodyPartType, IEnumerable<IBodyPart<string>>>();

                _bodyparts[Enum.BodyPartType.Foot] = value.Feet;
                _bodyparts[Enum.BodyPartType.Hand] = value.Hands;
                _bodyparts[Enum.BodyPartType.Head] = value.Heads;

            }
        }


        public virtual IDictionary<string, ICharacterAttribute> BaseAttributes
        {
            get
            {
                return _attributes;
            }

            set
            {
                _attributes = value;
            }
        }

        public virtual Body<string> 

        

        public virtual IEnumerable<IFoot<string>> Feet
        {
            get
            {

                return (IEnumerable<IFoot<string>>)_bodyparts[Enum.BodyPartType.Foot];
            }

            set
            {
                _bodyparts[Enum.BodyPartType.Foot] = value;
            }
        }

        public virtual IEnumerable<IHand<string>> Hands
        {
            get
            {
                return (IEnumerable<IHand<string>>)_bodyparts[Enum.BodyPartType.Hand];
            }

            set
            {
                _bodyparts[Enum.BodyPartType.Hand] = value;
            }
        }

        public virtual IEnumerable<IHead<string>> Heads
        {
            get
            {
                return (IEnumerable<IHead<string>>)_bodyparts[Enum.BodyPartType.Head];
            }

            set
            {
                _bodyparts[Enum.BodyPartType.Head] = value;
            }
        }

        public virtual IPersonalityTraits PersonalityTrait
        {
            get
            {
                return _pTraits;
            }

            set
            {
                _pTraits = value;
            }
        }

        public virtual string CharacterClass
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
            }
        }

        public virtual string DisplayName
        {
            get
            {
                return _name.FullName;
            }
            set
            {
                _name.FullName = value;
            }


        }

        public virtual string ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public virtual Name Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public virtual IEnumerable<IBodyPart<string>> GetBodyParts()
        {
            return (IEnumerable<IBodyPart<string>>)_bodyparts.Values;
        }

        public abstract IEnumerable<IRelationship<string>> GetRelationships();
       
        public string GetID()
        {
            return _id;
        }

        public Name GetName()
        {
            return _name;
        }

        public IEmotion GetCurrentEmotion()
        {
            return _emotion;
        }

        public abstract IEmotion GetPreviousEmotion();

        public abstract IEnumerable<IEmotion> GetEmotionHistory();

        public abstract IEnumerable<ICharacter<string>> GetChildren();

       
       

        #endregion Fields


    }
}
