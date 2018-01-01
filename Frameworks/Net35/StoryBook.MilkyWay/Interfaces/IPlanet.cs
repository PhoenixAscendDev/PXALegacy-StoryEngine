using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface  IPlanet : IWorld<string, Enum.WorldType>
    {
        


        IEnumerable<IRegion> GetRegions();

        IEnumerable<IMoon> GetMoons();
    }
}
