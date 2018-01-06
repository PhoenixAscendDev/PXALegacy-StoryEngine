using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public abstract class World<TID, Ttype> : JB2.Common.IDNamePair<TID, string>, JB2.Storybook.IWorld<TID, Ttype>
        where TID : IComparable
    {
        #region Fields
        protected double _gravity;
        protected double _minutesInDay;
        protected JB2.Sprog.IWeather _weather;
        protected List<ISpecies<TID>> _species;
        protected long _distance;
        protected TID _parentID;
        #endregion Fields

        #region Constructors

        public World()
        {

        }

        public World(TID id, string name) : base(id,name)
        {
            _species = new List<ISpecies<TID>>();
        }

        #endregion Constructors

        public double Gravity
        {
            get
            {
                return _gravity;
            }
            set
            {
                _gravity = value;
            }
        }

        public double MinutesInDay
        {
            get
            {
                return _minutesInDay;
            }

            set
            {
                _minutesInDay = value;
            }
        }

        public TID ParentID
        {
            get
            {
                return _parentID;
            }
            set
            {
                _parentID = value;
            }
        }

        public JB2.Sprog.IWeather WeatherCondition
        {
            get
            {
                return _weather;
            }

            set
            {
                _weather = value;
            }
        }

        public long DistanceFromParent
        {
            get
            {

                return _distance;
            }
            set
            {
                _distance = value;
            }
        }

        public abstract IEnumerable<IWorld<TID, Ttype>> GetChildren();

        public virtual IEnumerable<ISpecies<TID>> GetSpecies()
        {
            var list = new List<ISpecies<TID>>();

            list.AddRange(_species);

            foreach(var c in GetChildren())
            {
                list.AddRange(c.GetSpecies());
            }

            return list;

        }

        public abstract Ttype GetWorldType();
    }
}
