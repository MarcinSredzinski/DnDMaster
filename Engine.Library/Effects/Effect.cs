using Core.Library.Enums;
using Core.Library.Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Library.Effects
{
    public class Effect : IEffect
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public ApplicableProperty ConcerningProperty { get; set; }
    }
}
