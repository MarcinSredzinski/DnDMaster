using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Library.Attributes;
using Core.Library.Enums;
using Xunit;

namespace Engine.Library.Tests.Attributes
{
    public class AttributeTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(16)]
        [InlineData(24)]
        public void ModifierShouldCalculate(int value)
        {
            //Arrange
            Engine.Library.Attributes.Attribute attribute = new Engine.Library.Attributes.Attribute(AttributeName.Strenght, value);
            //Act
            int modifier = 0;
            modifier = (int)Math.Floor((double)((value - 10) / 2));

            //Assert
            Assert.Equal(modifier, attribute.Modifier);
        }
    }
}
