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
    public class Planet : World<string,Enum.WorldType>
    {
        #region Fields
        private List<IWorld<string,Enum.WorldType>> _children;
        private List<ISpecies<string>> _species;

        #endregion Fields
        public Planet()
        {
            _children = new List<IWorld<string, WorldType>>();
            _species = new List<ISpecies<string>>();
        }

        public Planet(string name,double gravity,double minutesInDay)
        {
            _name = name;
            _gravity = gravity;
            _minutesInDay = minutesInDay;
            _id = "MilkyWay-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=milyway?planet=" + this._name));
        }
        public override IEnumerable<IWorld<string,Enum.WorldType>> GetChildren()
        {
            return _children;
        }

        public override IEnumerable<ISpecies<string>> GetSpecies()
        {
            return _species;
        }

        public override WorldType GetWorldType()
        {
            return WorldType.Planet;
        }

        public void AddMoon(Moon moon)
        {
            _children.Add(moon);
        }

        public void AddSpecies(ISpecies<string> species)
        {
            _species.Add(species);
        }
        public static Planet Jupitor
        {
            get
            {
                return new Planet("Jupitor", 24.92, 1440);
            }
        }

        public static Planet Neptune
        {
            get
            {
                return new Planet("Neptune", 11.15, 1440);
            }
        }
        public static Planet Saturn
        {
            get
            {
                return new Planet("Saturn", 10.44, 1440);
            }
        }
        public static Planet Uranus
        {
            get
            {
                return new Planet("Uranus", 8.87, 1440);
            }
        }
        public static Planet Venus
        {
            get
            {
                return new Planet("Venus", 8.87, 1440);
            }
        }
        public static Planet Mars
        {
            get
            {
                return new Planet("Mars", 3.71, 1440);
            }
        }
        public static Planet Mercury
        {
            get
            {
                return new Planet("Mercury", 3.7, 1440);
            }
        }
        public static Planet Pluto
        {
            get
            {
                return new Planet("Pluto", 0.58, 1440);
            }
        }
        public static Planet Earth
        {
            get
            {
                var p = new Planet("Earth", 9.798, 1440);

                var moon = new Moon();
                moon.Name = "Moon";
                moon.Gravity = 1.62;

                p.AddSpecies(new Human());

                p.AddMoon(moon);

                return p;
            }
        }
    }


    
}
