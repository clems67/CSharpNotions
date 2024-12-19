using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnWithTesting
{
    public class JaggedArray
    {
        [Fact]
        public void jaggedArray()
        {
            //Arrange
            int[][] jaggedArr = new int[][]
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };

            //Act
            int x = jaggedArr[2][1];

            //Assert
            Assert.Equal(42, x);
        }
    }
}