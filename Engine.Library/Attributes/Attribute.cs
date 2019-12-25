using Core.Library.Enums;
using Core.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Library.Attributes
{
    public class Attribute : IAttribute
    {
        public Attribute(AttributeName name, int value)
        {
            Name = name;
            Value = value;
        }

        public AttributeName Name { get; private set; }
        public int Value { get; private set; }
        public int Modifier { get => (int)(Math.Floor((double)((Value >= 0) ? (Value - 10) / 2 : 0))); }
    }
}
