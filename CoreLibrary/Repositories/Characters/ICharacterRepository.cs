using Core.Library.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Repositories.Characters
{
    public interface ICharacterRepository : IRepository
    {
        Character GetCharacter(Guid id);
        List<Character> LoadCharacters();
        void InsertCharacter(Character character);
        void UpdateCharacter(Character character);
        void RemoveCharacter(Character character);

    }
}
