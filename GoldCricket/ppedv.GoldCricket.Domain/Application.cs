using System;
using System.Collections.Generic;

namespace ppedv.GoldCricket.Domain
{
    public class Application : Entity
    {
        public string Name { get; set; }
        public DateTime Started { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public virtual Person Owner { get; set; }
        public virtual HashSet<Database> Databases { get; set; } = new HashSet<Database>();
    }
}
