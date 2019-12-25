using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Library.Effects;
using Core.Library.Enums;

namespace Engine.Library.Tests.TestDataSources
{
    public class EfffectsTestDataCollection : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Effects.EffectsCollection(new List<IEffect>
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 3},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 1}
                    }
            )};
            yield return new object[] {new Effects.EffectsCollection(new List<IEffect>
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 0},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 3}

                    }

            )};
            yield return new object[] {new Effects.EffectsCollection(new List<IEffect>
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 7}
                    }
            )};
            yield return new object[] { new Effects.EffectsCollection(new List<IEffect>
                    {
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 1},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 3},
                        new Effects.Effect{ConcerningProperty= ApplicableProperty.Initiative, Value= 2}
                    }
            )};
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}