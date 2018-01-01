using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




using JB2.Storybook.Enum;

namespace JB2.Storybook
{
    public class Planet : World<string,Enum.WorldType> , IPlanet
        
    {
        #region Fields
        private List<IWorld<string,Enum.WorldType>> _children;


        #endregion Fields

        #region Constructor
        public Planet() : this(string.Empty,0.0,0)
        {

        }

        public Planet(string name,double gravity,double minutesInDay) 
            : base("MilkyWay-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=milyway?planet=" + name)),name)
        {           
            _gravity = gravity;
            _minutesInDay = minutesInDay;
            _children = new List<IWorld<string, WorldType>>();
            _species = new List<ISpecies<string>>();
            //_id = "Planet-" + JB2.Common.NewID.UriHash(new Uri("http://universe.jbsquared.com/unverse=milyway?planet=" + this._name));
        }

        #endregion Constructor

       
        public IEnumerable<IRegion> GetRegions()
        {
            return (IEnumerable<IRegion>)_children.Where(x => x.GetWorldType() == WorldType.Region);
        }

        public IEnumerable<IMoon> GetMoons()
        {
            return (IEnumerable<IMoon>)_children.Where(x => x.GetWorldType() == WorldType.Moon);
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

        public void AddMoon(IMoon moon)
        {
            _children.Add(moon);
        }

        public void AddRegion(IRegion region)
        {
            _children.Add(region);
        }

        public void AddSpecies(ISpecies<string> species)
        {
            _species.Add(species);
        }

        public static Planet Jupitor
        {
            get
            {
                var p = new Planet("Jupitor", 24.92, 1440);
                p.DistanceFromParent = 780000000;
                return p;
            }
        }

        public static Planet Neptune
        {
            get
            {
                var p = new Planet("Neptune", 11.15, 1440);
                p.DistanceFromParent = 4507500000;
                return p;
            }
        }
        public static Planet Saturn
        {
            get
            {
                var p =  new Planet("Saturn", 10.44, 1440);
                p.DistanceFromParent = 1437000000;
                return p;
            }
        }
        public static Planet Uranus
        {
            get
            {
                var p = new Planet("Uranus", 8.87, 1440);
                p.DistanceFromParent = 2880000000;
                return p;
            }
        }
        public static Planet Venus
        {
            get
            {
                var p =  new Planet("Venus", 8.87, 1440);
                p.DistanceFromParent = 108000000;
                return p;
            }
        }
        public static Planet Mars
        {
            get
            {
                var p =  new Planet("Mars", 3.71, 1440);
                p.DistanceFromParent = 228000000;
                return p;
            }
        }
        public static Planet Mercury
        {
            get
            {
                var p = new Planet("Mercury", 3.7, 1440);
                p.DistanceFromParent = 58500000;
                return p;
            }
        }
        public static Planet Pluto
        {
            get
            {
                var p =  new Planet("Pluto", 0.58, 1440);
                p.DistanceFromParent = 5992000000;
                return p;
            }
        }
        public static Planet Earth
        {
            get
            {
                var p = new Planet("Earth", 9.798, 1440);
                p.DistanceFromParent = 150000000;
                var moon = new Moon();
                moon.Name = "Moon";
                moon.Gravity = 1.62;
                moon.DistanceFromParent = 384400;
                p.AddSpecies(new Human());

                p.AddMoon(moon);

                return p;
            }
        }

        
    }


    
}
