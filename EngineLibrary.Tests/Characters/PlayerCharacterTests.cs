using Core.Library.Enums;
using Core.Library;
using Engine.Library.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Engine.Library.Tests.Characters
{
    public class PlayerCharacterTests
    {
        public PlayerCharacterTests()
        {
        }

        /// <summary>
        /// Initiative value should be sum of character's dextrity modifier and effect applying to initiative,
        /// such as atuts or spell's effects
        /// </summary>
        /// <param name="character"></param>
        [Theory]
        [ClassData(typeof(PlayerCharacterTestDataCollection))]
        public void TestInitiativeForMultiplePlayers(PlayerCharacter character)
        {
            int additionalInitiativeValue = (character.AdditionalEffects!= null)
                ? character.AdditionalEffects.Where(e => e.ConcerningProperty == ApplicableProperty.Initiative).Sum(e => e.Value)
                : 0;
          

            int expectedInitiative = character.Attributes.Dextrity.Value + additionalInitiativeValue;

            //Act
            int actualInitiative = character.Initiative;

            //Assert
            Assert.Equal(expectedInitiative, actualInitiative);
        }
    }
}

