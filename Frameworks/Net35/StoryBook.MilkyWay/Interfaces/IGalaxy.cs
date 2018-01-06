using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public interface IGalaxy : IMilkyWayWorld
    {
        IEnumerable<IStar> GetStars();
        IEnumerable<ISolarSystem> GetSolarSystems();
        IEnumerable<IPlanet> GetPlanets();

        void AddStar(IStar star);

        void AddSolarSystem(ISolarSystem solarSystem);


    }
}
