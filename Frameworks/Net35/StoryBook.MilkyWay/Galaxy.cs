using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using JB2.Storybook.Enum;

namespace JB2.Storybook
{
    public class Galaxy : World<string,Enum.WorldType>
    {
        #region Fields
        protected List<SolarSystem> _solarSystems;
        #endregion Fields

        public Galaxy()
        {
            
            _solarSystems = new List<SolarSystem>();
        }

        public Galaxy(string id, string name) : this()
        {
            _id = id;
            _name = name;
        }


        public override IEnumerable<IWorld<string, Enum.WorldType>> GetChildren()
        {
            return (IEnumerable<IWorld<string, Enum.WorldType>>)_solarSystems;
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
