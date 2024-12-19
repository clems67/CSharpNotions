namespace SoloLearnWithTesting
{
    public class PrefixAndPostfix
    {
        [Fact]
        public void IncrementOperators()
        {
            //Arrabge
            int x = 9;
            int y = 9;

            // Act
            int prefixX = ++y; //add 1 to y then proceed the operation
            int postfixY = x++; //proceed the operation then add 1 to x

            // Assert
            Assert.Equal(10, prefixX);            
            Assert.Equal(10, x);
            Assert.Equal(10, y);

            Assert.Equal(9, postfixY);
        }
    }
}