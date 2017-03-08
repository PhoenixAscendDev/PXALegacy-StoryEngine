using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JB2.Common;

namespace JB2.Engine.Storybook
{
    public interface IWorldRepo<TID,TWorldType>
        where TID : IComparable
    {

        IWorld<TID, TWorldType> GetWorldByID(string storyBookID, TID id);

        ServiceResult InsertWorld(string storyBookID, IWorld<TID, TWorldType> world);

        ISpecies<TID> GetSpecies(string storyBookID, TID id);

        ServiceResult InsertSpecies(string storyBookID, ISpecies<TID> species);
    }
}
