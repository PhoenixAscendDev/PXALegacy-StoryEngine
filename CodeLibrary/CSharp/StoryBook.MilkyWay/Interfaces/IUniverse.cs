using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IUniverse : IMilkyWayWorld
    {
        IEnumerable<IGalaxy> Galaxies { get; set; }
    }
}
