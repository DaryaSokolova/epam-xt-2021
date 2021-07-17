using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWithThreeLayers.Entities
{
    public class Award
    {
        public Award(Guid iD, string title)
        {
            ID = iD;
            Title = title;
        }

        public Guid ID { get; private set; }
        public string Title { get; private set; }
    }
}
