using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB2.StoryEngine
{
    public struct StoryGoal
    {
        public string Owner { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public short Utility { get; set; }
        public string Description { get; set; }
    }
}
