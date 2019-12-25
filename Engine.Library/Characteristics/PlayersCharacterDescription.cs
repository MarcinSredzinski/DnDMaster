using System;
using System.Collections.Generic;
using System.Text;
using Core.Library.Characteristics;

namespace Engine.Library.Characteristics
{
    public class PlayersCharacterDescription : Description
    {
        public string PlayerName { get; set; }
        public string CharactersHistory { get; set; }
        public string Religion { get; set; }
        public string VisualDescription { get; set; }
    }
}
