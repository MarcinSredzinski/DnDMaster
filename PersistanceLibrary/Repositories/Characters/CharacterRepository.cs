using Core.Library.Characters;
using CoreLibrary.Repositories.Characters;
using System;
using System.Collections.Generic;
using System.Text;
using PersistanceLibrary.MongoSpecific;

namespace PersistanceLibrary.Repositories.Characters
{
    public class CharacterRepository : MongoCRUD, ICharacterRepository
    {
        private readonly string table = "characters";
        public CharacterRepository(string database) : base(database)
        {
        }

        public Character GetCharacter(Guid id)
        {
            return base.LoadById<Character>(table, id);
        }

        public void InsertCharacter(Character character)
        {
            base.Upsert<Character>(table, new Guid(), character);
        }

        public List<Character> LoadCharacters()
        {
            throw new NotImplementedException();
        }

        public void RemoveCharacter(Character character)
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacter(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
