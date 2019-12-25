using Core.Library.Attributes;
using Core.Library.Characteristics;
using Core.Library.Effects;
using Core.Library.Enums;
using System.Linq;

namespace Core.Library.Characters
{
    public abstract class Character
    {
        protected Character(AttributesSet attributes, IEffectsCollection startingEffects)
        {
            Attributes = attributes;
            AdditionalEffects = startingEffects;
        }

        public AttributesSet Attributes { get; private set; } 
        public Description Characteristics { get; set; }
        
        public IEffectsCollection AdditionalEffects { get; private set; }
       
        /// <summary>
        ///calculated value of initiative
        ///this one should be straight forward - attributes.dextrity + feats + spells
        /// </summary>
        public int Initiative
        {
            get => Attributes.Dextrity.Value
                + ((AdditionalEffects != null)
                ? AdditionalEffects.Where(e => e.ConcerningProperty == ApplicableProperty.Initiative).Sum(e => e.Value)
                : 0);
        }
    }
}
