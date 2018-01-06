using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JB2.Storybook.Enum;

namespace JB2.Storybook
{
    public abstract class MilkyWayWorld : World<string,Enum.WorldType>, IMilkyWayWorld
    {
        #region Fields

        protected List<IMilkyWayWorld> _children;

        #endregion Fields

        #region Constructor

        public MilkyWayWorld() : this(JB2.Common.NewID.Guid(), string.Empty)
        {

        }

        public MilkyWayWorld(string id, string name) : base(id,name)
        {
            _children = new List<IMilkyWayWorld>();
        }

        #endregion Constructor


        public override IEnumerable<IWorld<string, WorldType>> GetChildren()
        {
            return (IEnumerable<IWorld<string, WorldType>>)_children;
        }


    }
}
