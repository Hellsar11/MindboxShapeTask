using MBoxShapeLib.Classes.Figures;
using Xunit;

namespace MBoxShapeLib.Tests.Shape
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleSquare_7_5_4_Return_9_8()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 7, 5, 4);

            //Act
            var shapeSquare = triangle.CalculateSquare();

            //Assert
            Assert.Equal(9.8, shapeSquare);
        }

        [Fact]
        public void IsRectangular_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 7, 5, 4);

            //Act
            var isRectangular = triangle.IsRectangular();

            //Assert
            Assert.False(isRectangular);
        }
    }
}
