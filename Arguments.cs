using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnWithTesting
{
    public class Arguments
    {
        static int Power(int baseNumber, int exponent = 2)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }

        [Fact]
        public void OptionalArguments()
        {
            //Arrange
            //Act
            int x = Power(6); //no argument so it's the default one : exponent = 2
            int y = Power(2, 5);

            //Assert
            Assert.Equal(36, x);
            Assert.Equal(32, y);
        }
        [Fact]
        public void NamedArguments()
        {
            //Arange
            //Act
            int x = Power(exponent: 5, baseNumber: 2); //you can pass arguments in the order you like this way

            //Assert
            Assert.Equal(32, x);
        }
        static void Sqr(int x)
        {
            x = x * x;
        }
        [Fact]
        public void PassingArguments()
        {
            //Arrange
            int x = 3;

            //Act
            Sqr(x);

            //Assert
            Assert.Equal(3, x);
        }

        static void SqrWithRef(ref int x)
        {
            x = x * x;
        }
        [Fact]
        public void PassingByReference()
        {
            //Arrange
            int x = 3; //value must be initialized

            //Act
            SqrWithRef(ref x);

            //Assert
            Assert.Equal(9, x);
        }

        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        [Fact]
        public void PassingByOutput()
        {
            //Arrange
            int a, b; //values must NOT be initialized

            //Act
            GetValues(out a, out b);

            //Assert
            Assert.Equal(5, a);
            Assert.Equal(42, b);
        }
    }
}
