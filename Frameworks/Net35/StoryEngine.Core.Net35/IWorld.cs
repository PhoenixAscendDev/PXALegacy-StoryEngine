using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using JB2.Sprog;

namespace JB2.Storybook
{
    public interface IWorld<TID,TType> : JB2.Common.IIDNamePair<TID,string>
        where TID : IComparable
    {
        IWeather WeatherCondition { get; set; }

        double MinutesInDay { get; set; }

        double Gravity { get; set; }

        IEnumerable<ISpecies<TID>> GetSpecies();

        IEnumerable<IWorld<TID,TType>> GetChildren();

        TType GetWorldType();

        long DistanceFromParent { get; set; }

        TID ParentID { get; set; }


    }
}
