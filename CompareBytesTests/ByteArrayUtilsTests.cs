using Xunit;
using static CompareBytes.ByteArrayUtils;

namespace CompareBytesTests
{
    public class ByteArrayUtilsTests
    {
        [Fact]
        public void ArrayToStringTest()
        {
            byte[] byteArray = {62, 27, 200, 135, 105, 210};
            const string resultDecimal = "62 27 200 135 105 210",
                resultHexadecimal = "3e 1b c8 87 69 d2";
            Assert.Equal(resultDecimal, ArrayToString(byteArray));
            Assert.Equal(resultHexadecimal, ArrayToString(byteArray, PrintFormat.Hexadecimal));

            // Empty array
            Assert.Equal(string.Empty, ArrayToString(new byte[0]));
        }

        [Fact]
        public void EqualTest()
        {
            byte[] array1 = {98, 166},
                array2 = {231, 172, 16, 32, 31, 84},
                array3 = {231, 172, 216, 32, 31, 84},
                array4 = {231, 172, 216, 32, 31, 84};

            // Arrays are null -> false
            Assert.False(Equal(array1, null));
            Assert.False(Equal(null, array1));
            Assert.False(Equal(null, null));

            // Arrays are different in size -> false
            Assert.False(Equal(array1, array3));
            Assert.False(Equal(array1, array4));

            // Arrays are different -> false
            Assert.False(Equal(array3, array2));
            Assert.False(Equal(array4, array2));

            // Arrays are equal
            Assert.True(Equal(array3, array4));
        }
    }
}