using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JB2.Storybook
{
    public struct StoryBelief
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Likelihood { get; set; }
        public string Agent { get; set; }
        public IEnumerable<string> Goals { get; set; }
        public double Congruence { get; set; }
    }
}
