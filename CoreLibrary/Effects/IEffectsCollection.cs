using System.Collections.Generic;
using Core.Library.Effects;

namespace Core.Library.Effects
{
    public interface IEffectsCollection : IList<IEffect>
    {
        IList<IEffect> Effects { get; }
        new void Add(IEffect effect);
        void AddRangeEffects(IEnumerable<IEffect> addedEffects);
        new void Remove(IEffect effect);
    }
}