using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Sprog;

namespace JB2.Engine.Storybook
{
    public interface IWorld<TID> : JB2.Common.IIDProp<TID>
        where TID : IComparable
    {
        IWeather WeatherCondition { get; set; }

        double MinutesInDay { get; set; }

        double Gravity { get; set; }

        IEnumerable<ISpecies<TID>> Species { get; set; }
    }
}
