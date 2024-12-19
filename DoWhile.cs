using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnWithTesting
{
    public class DoWhile
    {
        [Fact]
        public void doWhile()
        {
            //Arrange
            int x = 1;
            int y = 0;

            //Act
            do
            {
                x++; //done once
            }
            while (x < y); //stop there

            //Assert
            Assert.Equal(2, x);
        }
    }
}
