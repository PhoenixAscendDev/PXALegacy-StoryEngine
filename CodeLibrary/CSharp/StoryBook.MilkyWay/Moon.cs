using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Engine.Storybook;
using JB2.Storybook.MilkyWay.Enum;

namespace JB2.Storybook.MilkyWay
{
    public class Moon : World<string, Enum.WorldType>
    {
        public override IEnumerable<IWorld<string, WorldType>> GetChildren()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<ISpecies<string>> GetSpecies()
        {
            throw new NotImplementedException();
        }

        public override WorldType GetWorldType()
        {
            return WorldType.Moon;
        }
    }
}
