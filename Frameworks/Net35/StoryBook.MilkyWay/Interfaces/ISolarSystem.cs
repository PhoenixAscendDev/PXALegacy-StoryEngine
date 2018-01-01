using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface ISolarSystem : IWorld<string,Enum.WorldType>
    {
       IEnumerable<IPlanet> Planets { get; set; }   
    }
}
