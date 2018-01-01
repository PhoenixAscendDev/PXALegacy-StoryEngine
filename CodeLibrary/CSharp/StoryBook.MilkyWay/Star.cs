using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using JB2.Storybook.Enum;

namespace JB2.Storybook
{
    public class Star : World<string, Enum.WorldType>, IStar
    {
        #region Fields

        ISolarSystem _solarSystems;

        #endregion Fields

        #region Constructors

        public Star() : this(string.Empty,string.Empty)
        {
            
        }

        public Star(string id, string name) : base(id,name)
        {

            _solarSystems = null;
        }

        #endregion Constructors

        public ISolarSystem SolarSystem
        {
            get
            {
                return _solarSystems;
            }
            set
            {
                _solarSystems = value;
            }
        }

        public override IEnumerable<IWorld<string, WorldType>> GetChildren()
        {
            return new IWorld<string, WorldType>[1] { _solarSystems };
        }

       

        public override WorldType GetWorldType()
        {
            return WorldType.Star;
        }
    }
}
