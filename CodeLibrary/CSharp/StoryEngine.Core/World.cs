using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JB2.Engine.Storybook;

namespace JB2.Engine.Storybook
{
    public abstract class World<TID, Ttype> : JB2.Common.IDNamePair<TID, string>, JB2.Engine.Storybook.IWorld<TID, Ttype>
        where TID : IComparable
    {
        #region Fields
        protected double _gravity;
        protected double _minutesInDay;
        protected JB2.Sprog.IWeather _weather;
        #endregion Fields
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

        public abstract IEnumerable<IWorld<TID, Ttype>> GetChildren();


        public abstract IEnumerable<ISpecies<TID>> GetSpecies();

        public abstract Ttype GetWorldType();
    }
}
