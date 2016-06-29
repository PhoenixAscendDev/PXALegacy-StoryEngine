using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Sprog;

namespace JB2.Engine.Storybook
{
    public interface IWorld
    {
        IWeather WeatherCondition { get; set; }

        double MinutesInDay { get; set; }

    }
}
