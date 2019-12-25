using System.Collections.Generic;
using System.Linq;
using Core.Library.Attributes;
using Core.Library.Characters;
using Core.Library.Effects;
using Engine.Library.Attributes;
using Engine.Library.Characteristics;
using Engine.Library.Effects;

namespace Engine.Library.Characters
{
    public class PlayerCharacter : Character, IPlayerCharacter
    {
        public PlayerCharacter(AttributesSet attributes, IEffectsCollection startingEffects) : base(attributes, startingEffects)
        {
        }

        public new PlayersCharacterDescription Characteristics { get; set; }

        /*
          /// <summary>
          ///calculated actual hitpoints
          /// </summary>
          public HitPoints HitPoints { get; set; }


          /// <summary>
          ///information about armour and calculating certain armour class values
          ///will calculate armour class values to touch to hit supprised etc
          /// </summary>
          public Armour Armour { get; set; }

          /// <summary>
          ///strenght, dextrity wisdom etc,
          ///consists of Base attributes, race attributes, level gained attributes, items and spells
          /// </summary>
          public Attributes Attributes { get; set; }

          /// <summary>
          ///skills such as acrobacy, knowledges, hiding etc
          ///will take form of base class with all the methods and DTO
          ///need to consederate how to bind attribute to the apropriate skill
          /// </summary>
          public Skills Skills { get; set; }

          /// <summary>
          ///list of levels in classes or single element containing all the information
          /// </summary>
          public Levels Levels { get; set; }

          /// <summary>
          ///  this collection should contain list of all feats a character has, like Power Attack etc
          /// </summary>
          public IEnumerable<Feats> Feats { get; set; }
          /// <summary>
          /// calculated value of base attack bonuses from all the classes
          /// </summary>
          public void BaseAttackBonus()
          { //return BaseAttackBonus
          }
          //calculated value of base saves values of all the classes
          public void GetSavesValue()
          { //return SavesValue
          }
          */
    }
}
