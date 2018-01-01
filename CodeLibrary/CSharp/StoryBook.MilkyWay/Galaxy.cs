using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using JB2.Storybook.Enum;

namespace JB2.Storybook
{
    public class Galaxy : MilkyWayWorld, IGalaxy
    {
        #region Fields
        //protected List<SolarSystem> _solarSystems;
        //protected List<IStar> _stars;
        #endregion Fields

        #region Constructors

        public Galaxy() : this(JB2.Common.NewID.Guid(),string.Empty)
        {
            
            

        }

        public Galaxy(string id, string name) : base(id,name)
        {
            _id = id;
            _name = name;
            
        }

        #endregion Constructors

        public override string GetID()
        {
            return _id;
        }

        //public override IEnumerable<ISpecies<string>> GetSpecies()
        //{
        //    List<ISpecies<string>> result = new List<ISpecies<string>>();
        //    foreach (var p in _solarSystems)
        //    {
        //        result.AddRange(p.GetSpecies());
        //    }

        //    return result;
        //}

        public override WorldType GetWorldType()
        {
            return WorldType.Galaxy;
        }

        public void AddSolarSystem(SolarSystem s)
        {
            s.ParentID = this.ID;
            _children.Add(s);
            //_solarSystems.Add(s);
        }

        public void AddStar(IStar s)
        {
            s.ParentID = this.ID;
            _children.Add(s);
            //_stars.Add(s);
        }

        public void AddSolarSystem(ISolarSystem s)
        {
            s.ParentID = this.ID;
            _children.Add(s);
            //_stars.Add(s);
        }

        public IEnumerable<IStar> GetStars()
        {
            return (IEnumerable<IStar>)_children.Where(x => x.GetType() is IStar);
        }

        public IEnumerable<ISolarSystem> GetSolarSystems()
        {
            return (IEnumerable<ISolarSystem>)_children.Where(x => x.GetType() is ISolarSystem);
        }

        public IEnumerable<IPlanet> GetPlanets()
        {
            return (IEnumerable<IPlanet>)_children.Where(x => x.GetType() is IPlanet);
        }

        
    }
}
