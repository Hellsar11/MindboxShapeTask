using MBoxShapeLib.Classes.Figures;
using Xunit;

namespace MBoxShapeLib.Tests.Shape
{
    
    public class CircleTest
    {
        [Fact]
        public void CircleSquare_8_Return_201_1()
        {
            //Arrange
            Circle circle = new Circle("Круг", 8);

            //Act
            var shapeSquare = circle.CalculateSquare();

            //Assert
            Assert.Equal(201.1, shapeSquare);
        }
    }
}