using Engine.Library.Effects;
using Core.Library.Characters;
using Core.Library.Effects;
using CoreLibrary.Services;
using Core.Library.Characteristics;
using CoreLibrary.Enums;
using System.Linq;

namespace Engine.Library.Services
{
    public class CharacterService : ICharacterService
    {
        /// <summary>
        /// Character is passed from repository or there is new character created.
        /// </summary>
        /// <param name="character">Character used in all of this class operations</param>
        public CharacterService(Character character)
        {
            _character = character;
        }
        private Character _character;
        //ToDo I have huge doubts here, because returning the reference to the object isn't what I want
        // everyone can skip the service and just start working directly on the _character object which may cause malfunction
        //Instead I should implement "DeepClone" interface and "GetDeepClonedCopy" method. 
        public Character Character { get => _character; }

        public void AddEffect(IEffect effect)
        {
            _character.AdditionalEffects.Add(effect);
        }
        public void RemoveEffect(IEffect effect)
        {
            _character.AdditionalEffects.Remove(effect);
        }

        public Character GenerateCharacter(CharactersTypes charactersType)
        {
            throw new System.NotImplementedException();
        }

    }
}
