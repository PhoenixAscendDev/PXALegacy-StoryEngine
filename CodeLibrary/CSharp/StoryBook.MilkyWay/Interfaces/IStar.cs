using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IStar : IWorld<string, Enum.WorldType>
    {
        ISolarSystem SolarSystem { get; set; }
    }
}
