using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Library.Attributes
{
    public abstract class AttributesSet
    {       
        public IAttribute Strenght { get; protected set; }
        public IAttribute Dextrity { get; protected set; }
        public IAttribute Constitution { get; protected set; }
        public IAttribute Wisdom { get; protected set; }
        public IAttribute Intellect { get; protected set; }
        public IAttribute Charisma { get; protected set; }
    }
}
