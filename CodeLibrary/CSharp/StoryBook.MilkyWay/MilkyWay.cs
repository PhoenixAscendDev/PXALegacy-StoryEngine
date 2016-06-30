using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Engine.Storybook;
using JB2.Storybook.MilkyWay.Enum;

namespace JB2.Storybook.MilkyWay
{
    public class MilkyWay : World<string,Enum.WorldType>
    {
        #region Fields
        protected List<SolarSystem> _solarSystems;
        #endregion Fields

        public MilkyWay()
        {
            _id = "MilkyWay-" + JB2.Common.NewID.UriHash( new Uri("http://universe.jbsquared.com/unverse=milyway"));
            _name = "MilkyWay";
            _solarSystems = new List<SolarSystem>();
        }


        public override IEnumerable<IWorld<string, Enum.WorldType>> GetChildren()
        {
            return _solarSystems;
        }

        public override string GetID()
        {
            return _id;
        }

        public override IEnumerable<ISpecies<string>> GetSpecies()
        {
            List<ISpecies<string>> result = new List<ISpecies<string>>();
            foreach (var p in _solarSystems)
            {
                result.AddRange(p.GetSpecies());
            }

            return result;
        }

        public override WorldType GetWorldType()
        {
            return WorldType.Galaxy;
        }

        public void AddSolarSystem(SolarSystem s)
        {
            _solarSystems.Add(s);
        }
    }
}
