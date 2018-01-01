using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using JB2.Storybook.Enum;


namespace JB2.Storybook
{
    public class Moon : World<string, Enum.WorldType>, IMoon
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
