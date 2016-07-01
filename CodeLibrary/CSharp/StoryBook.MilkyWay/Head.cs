using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.Storybook.MilkyWay
{
    public class Head : JB2.Common.IDNamePair<string,string>,JB2.Engine.Storybook.IHead<string>
    {
    }

    public class Hand : JB2.Common.IDNamePair<string, string>, JB2.Engine.Storybook.IHand<string>
    {
        public Hand(int fingers) : base()
        {
         
        }

        public Hand(): this(5)
        {

        }
    }

    public class Foot : JB2.Common.IDNamePair<string, string>, JB2.Engine.Storybook.IFoot<string>
    {
        public Foot(int fingers) : base()
        {

        }

        public Foot(): this(5)
        {

        }
    }



}
