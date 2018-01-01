using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface ISolarSystem : IMilkyWayWorld, IEnumerable<IPlanet>
    {
       IEnumerable<IPlanet> Planets { get; set; }   
    }
}
