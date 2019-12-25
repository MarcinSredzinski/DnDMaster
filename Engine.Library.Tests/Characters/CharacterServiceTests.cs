using Engine.Library.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Engine.Library.Tests.Characters
{
    public class CharacterServiceTests
    {
        [Theory]
        [ClassData(typeof(PlayerCharacterTestDataCollection))]
        public void EffectsShouldBeAdded(Character character)
        {
            CharacterService characterService = new CharacterService(character);

            var listOfEffects = character.AdditionalEffects;
        }
    }
}
