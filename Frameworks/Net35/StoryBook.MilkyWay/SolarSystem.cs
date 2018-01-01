using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using JB2.Storybook.Enum;

namespace JB2.Storybook
{
    public class SolarSystem : World<string,Enum.WorldType>, ISolarSystem
    {
        protected IDictionary<string, IPlanet> _planets;

        public IEnumerable<IPlanet> Planets
        {
            get
            {
                return _planets.Values;
            }
            set
            {
                foreach(var v in value)
                {
                    if (!_planets.ContainsKey(v.ID))
                        _planets.Add(v.ID, v);
                    else
                        _planets[v.ID] = v;
                }
            }
        }

        public SolarSystem()
        {
            _planets = new Dictionary<string, IPlanet>();
            _id = "MilkyWay-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=solarsystem"));
            _name = "Solar System";
        }



        public override IEnumerable<IWorld<string,Enum.WorldType>> GetChildren()
        {
            return (IEnumerable<IWorld<string, Enum.WorldType>>)_planets.Values.ToList();
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
