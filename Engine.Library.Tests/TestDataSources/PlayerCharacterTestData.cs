using Engine.Library.Attributes;
using System.Collections;
using System.Collections.Generic;
using Engine.Library.Characters;
using Core.Library.Enums;

namespace Engine.Library.Tests.Characters
{
    public class PlayerCharacterTestDataCollection : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new PlayerCharacter(new DnDAttributesSet(0, 0, 0, 0, 0, 0), new Effects.EffectsCollection()
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 3},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 1}
                    })
            };
            yield return new object[] {
                new PlayerCharacter(new DnDAttributesSet(8, 8, 8, 8, 8, 8),new Effects.EffectsCollection()
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 0},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 3}

                    })

            };
            yield return new object[] {
                new PlayerCharacter(new DnDAttributesSet(12, 12, 12, 12, 12, 12),new Effects.EffectsCollection()
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 7}
                    })
            };
            yield return new object[] {
                new PlayerCharacter(new DnDAttributesSet(16, 16, 16, 16, 16, 16), new Effects.EffectsCollection()
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 1},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 3},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 2}
                    })
            };
            yield return new object[] { new PlayerCharacter(new DnDAttributesSet(16, 16, 16, 16, 16, 16), null) };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}