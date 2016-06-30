using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Common;
using JB2.Engine.Storybook;
using JB2.Storybook.MilkyWay.Enum;

namespace JB2.Storybook.MilkyWay
{
    public class SolarSystem : World<string,Enum.WorldType>
    {
        protected IDictionary<string, Planet> _planets;

        public SolarSystem()
        {
            _planets = new Dictionary<string, Planet>();
            _id = "MilkyWay-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=solarsystem"));
            _name = "Solar System";
        }
        public override IEnumerable<IWorld<string,Enum.WorldType>> GetChildren()
        {
            return _planets.Values.ToList();
        }

        public override IEnumerable<ISpecies<string>> GetSpecies()
        {
            List<ISpecies<string>> result = new List<ISpecies<string>>();
            foreach(var p in _planets.Values)
            {
                result.AddRange(p.GetSpecies());
            }

            return result;
        }

        public override WorldType GetWorldType()
        {
            return WorldType.Solarsystem;
        }

        public void AddPlanet(Planet p)
        {
            if (!_planets.ContainsKey(p.GetName()))
                _planets.Add(p.GetName(), p);
        }
    }
}
