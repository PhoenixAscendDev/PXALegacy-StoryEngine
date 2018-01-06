using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using JB2.Storybook.Enum;



namespace JB2.Storybook
{

    public class Universe
    {
        private static Galaxy _milkyway;
        private static List<IWorld<string, WorldType>> _galaxies = new List<IWorld<string, WorldType>>();
        public static Galaxy MilkyWay
        {
            get
            {
                if(_milkyway == null)
                {
                    _milkyway = new Galaxy("MilkyWay-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=milkyway"))
                                            ,"MilkyWay");

                    var sun = new Star("Sun-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=milkyway"))
                                       , "Sun");

                    var s = new SolarSystem("SolarSystem-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=solarsystem")),
                                           "Solar System");
                    s.AddPlanet(Planet.Earth);
                    s.AddPlanet(Planet.Jupitor);
                    s.AddPlanet(Planet.Mars);
                    s.AddPlanet(Planet.Mercury);
                    s.AddPlanet(Planet.Neptune);
                    s.AddPlanet(Planet.Pluto);
                    s.AddPlanet(Planet.Saturn);
                    s.AddPlanet(Planet.Uranus);
                    s.AddPlanet(Planet.Venus);

                    sun.AddSolarSystem(s);
                    
                    _milkyway.AddStar(sun);
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
