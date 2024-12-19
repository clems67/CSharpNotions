using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnWithTesting
{
    public class BreakContinue
    {
        [Fact]
        public void breakContinue()
        {
            //Arrange
            List<int> l = new List<int>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    continue;
                }
                l.Add(i);
            }

            //Assert
            Assert.Equal(new List<int> { 0, 2, 4 }, l);
        }
    }
}
