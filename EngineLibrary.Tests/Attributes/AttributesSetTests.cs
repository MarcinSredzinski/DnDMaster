using Xunit;

namespace Engine.Library.Tests.Attributes
{
    public class AttributesSetTests
    {
        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0)]
        [InlineData(8, 8, 8, 8, 8, 8)]
        [InlineData(14, 14, 14, 14, 14, 14)]
        public void AttributesValuesShouldBeAssigned(int strenght, int dextrity, int constitution,
            int wisdom, int intellect, int charisma)
        {
            //Arrange 
            var attributes = new Library.Attributes.DnDAttributesSet(strenght, dextrity, constitution, wisdom, intellect, charisma);

            //Act

            //Assert
            Assert.Equal(strenght, attributes.Strenght.Value);
            Assert.Equal(dextrity, attributes.Dextrity.Value);
            Assert.Equal(constitution, attributes.Constitution.Value);
            Assert.Equal(wisdom, attributes.Wisdom.Value);
            Assert.Equal(intellect, attributes.Intellect.Value);
            Assert.Equal(charisma, attributes.Charisma.Value);
        }
    }
}
