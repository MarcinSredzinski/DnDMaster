using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Library.Effects;

namespace Engine.Library.Effects
{
    public class EffectsCollection : List<IEffect>, IEffectsCollection
    {

        public EffectsCollection(IList<IEffect> effects)
        {
            _effects = effects;
        }

        private IList<IEffect> _effects;
        public IList<IEffect> Effects => _effects.ToList<IEffect>();
        public new void Add(IEffect effect)
        {
            _effects.Add(effect);
        }
        public void AddRangeEffects(IEnumerable<IEffect> addedEffects)
        {
            _effects.Concat(addedEffects);
        }

        public new void Remove(IEffect effect)
        {
            if (!_effects.Remove(effect))
            {
                _effects.Remove(_effects
                    .Where(e => ((e.ConcerningProperty == effect.ConcerningProperty) & (e.Value == effect.Value))).FirstOrDefault());
            };
        }
    }
}
