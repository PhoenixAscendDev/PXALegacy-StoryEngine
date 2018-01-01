using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public class Head : JB2.Common.IDNamePair<string,string>,JB2.Storybook.IHead<string>
    {
    }

    public class Hand : JB2.Common.IDNamePair<string, string>, JB2.Storybook.IHand<string>
    {
        public Hand(int fingers) : base()
        {
         
        }

        public Hand(): this(5)
        {

        }
    }

    public class Foot : JB2.Common.IDNamePair<string, string>, JB2.Storybook.IFoot<string>
    {
        public Foot(int fingers) : base()
        {

        }

        public Foot(): this(5)
        {

        }
    }



}
