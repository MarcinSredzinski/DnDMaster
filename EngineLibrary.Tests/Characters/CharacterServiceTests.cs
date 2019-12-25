using Engine.Library.Services;
using Core.Library.Characters;
using Xunit;
using Engine.Library.Effects;
using System.Linq;
using Core.Library.Effects;
using CoreLibrary.Services;

namespace Engine.Library.Tests.Characters
{
    public class CharacterServiceTests
    {
        public CharacterServiceTests()
        {
            newEffect = new Effect()
            {
                ConcerningProperty = Core.Library.Enums.ApplicableProperty.Initiative,
                Name = "SuperSpeed",
                Value = 3
            };
        }
        IEffect newEffect;
        IEffectsCollection listOfEffects;
        ICharacterService characterService;

        [Theory]
        [ClassData(typeof(PlayerCharacterTestDataCollection))]
        public void EffectsShouldBeAdded(Character character)
        {
            if (character.AdditionalEffects != null)
            {
                //arrange
                characterService = new CharacterService(character);
                listOfEffects = new EffectsCollection(character.AdditionalEffects.Effects.ToList<IEffect>());

                //Act
                characterService.AddEffect(newEffect);
                listOfEffects.Add(newEffect);

                //Assert
                Assert.Equal(listOfEffects.Effects.Count, character.AdditionalEffects.Effects.Count);
            }
        }
        [Theory]
        [ClassData(typeof(PlayerCharacterTestDataCollection))]
        public void EffectsShouldSubstract(Character character)
        {
            if (character.AdditionalEffects != null)
            {
                //Arrange
                characterService = new CharacterService(character);
                listOfEffects = new EffectsCollection(character.AdditionalEffects.Effects.ToList<IEffect>());
                //Act
                characterService.AddEffect(newEffect);
                characterService.RemoveEffect(newEffect);
                //Assert
                Assert.Equal(listOfEffects.Effects.Count, character.AdditionalEffects.Effects.Count);
            }
        }
    }
}

