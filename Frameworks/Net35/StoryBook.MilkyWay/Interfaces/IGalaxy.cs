using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IGalaxy : IWorld<string, Enum.WorldType>
    {
        IEnumerable<IStar> Stars { get; set; }
        IEnumerable<ISolarSystem> SolarSystems { get; set; }
        IEnumerable<IPlanet> Planets { get; set; }


    }
}
