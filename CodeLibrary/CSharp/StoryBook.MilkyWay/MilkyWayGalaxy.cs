using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Engine.Storybook;
using JB2.Storybook.MilkyWay.Enum;
using JB2.Storybook.MilkyWay;

namespace JB2
{

    public static class Universe
    {
        private static MilkyWay _milkyway;
        private static List<IWorld<string, WorldType>> _galaxies = new List<IWorld<string, WorldType>>();
        public static MilkyWay MilkyWay
        {
            get
            {
                if(_milkyway == null)
                {
                    _milkyway = new MilkyWay();
                    var s = new SolarSystem();
                    s.AddPlanet(Planet.Earth);
                    s.AddPlanet(Planet.Jupitor);
                    s.AddPlanet(Planet.Mars);
                    s.AddPlanet(Planet.Mercury);
                    s.AddPlanet(Planet.Neptune);
                    s.AddPlanet(Planet.Pluto);
                    s.AddPlanet(Planet.Saturn);
                    s.AddPlanet(Planet.Uranus);
                    s.AddPlanet(Planet.Venus);
                    _milkyway.AddSolarSystem(s);
                }
                return _milkyway;
            }
        }

        public static Planet GetMilkyWayPlanet(string name)
        {
            Planet result = null;
            foreach(var s in _milkyway.GetChildren())
            {
                if (s is Planet && s.GetName() == name)
                    result = (Planet)s;
                foreach(var p in s.GetChildren())
                {
                    if (p is Planet && p.GetName() == name)
                        result = (Planet)p;
                }
            }
            return result;
        }

        public static void AddWorld(IWorld<string, WorldType> world)
        {
            _galaxies.Add(world);
        }
    }
}
