using Core.Library.Characteristics;
using Core.Library.Characters;
using Core.Library.Effects;
using CoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Services
{
    public interface ICharacterService : IService
    {
        /// <summary>
        /// Generates new character of specyfic type
        /// </summary>
        /// <param name="charactersType">Enumerator describing the type of the character(player character, npc etc)</param>
        /// <returns></returns>
        Character GenerateCharacter(CharactersTypes charactersType);
        void AddEffect(IEffect effect);
        void RemoveEffect(IEffect effect);
    }
}
