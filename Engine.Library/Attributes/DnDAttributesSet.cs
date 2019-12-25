using System;
using System.Collections.Generic;
using System.Text;
using Core.Library.Enums;
using Core.Library.Attributes;

namespace Engine.Library.Attributes
{
    public class DnDAttributesSet : AttributesSet
    {
        public DnDAttributesSet(int strenght, int dextrity, int constitution, int wisdom, int intellect, int charisma)
        {
            Strenght = new Attribute(AttributeName.Strenght, strenght);
            Dextrity = new Attribute(AttributeName.Dextrity, dextrity);
            Constitution = new Attribute(AttributeName.Constitution, constitution);
            Wisdom = new Attribute(AttributeName.Wisdom, wisdom);
            Intellect = new Attribute(AttributeName.Intellect, intellect);
            Charisma = new Attribute(AttributeName.Charisma, charisma);
        }
    }
}
