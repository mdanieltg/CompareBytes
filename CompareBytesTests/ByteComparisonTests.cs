using Xunit;
using static CompareBytes.ByteComparison;

namespace CompareBytesTests
{
    public class ByteComparisonTests
    {
        [Fact]
        public void CompareFirstBytesTest()
        {
            byte[] byteArrayA, byteArrayB;

            // Both arrays are equal
            byteArrayA = new byte[] {61, 55, 37, 65, 187, 178};
            byteArrayB = new byte[] {61, 55, 37, 65, 187, 178};
            Assert.Equal(6, CompareFirstBytes(byteArrayA, byteArrayB).Length);

            // Arrays are somewhat similar
            byteArrayB = new byte[] {61, 55, 19, 100, 228, 222, 142};
            Assert.Equal(2, CompareFirstBytes(byteArrayA, byteArrayB).Length);

            // Both arrays are different
            byteArrayB = new byte[] {127, 1, 3, 161, 19, 192, 193, 48, 215, 98, 50, 181};
            Assert.Equal(0, CompareFirstBytes(byteArrayA, byteArrayB).Length);

            // One array is empty
            Assert.Equal(0, CompareFirstBytes(byteArrayA, new byte[0]).Length);

            // One or more arrays are null
            Assert.Equal(0, CompareFirstBytes(null, byteArrayB).Length);
            Assert.Equal(0, CompareFirstBytes(byteArrayA, null).Length);
            Assert.Equal(0, CompareFirstBytes(null, null).Length);
        }

        [Fact]
        public void CompareLastBytesTest()
        {
            byte[] byteArrayA, byteArrayB;

            // Both arrays are equal
            byteArrayA = new byte[] {162, 49, 242, 65, 187, 178};
            byteArrayB = new byte[] {162, 49, 242, 65, 187, 178};
            Assert.Equal(6, CompareLastBytes(byteArrayA, byteArrayB).Length);

            // Arrays are somewhat similar
            byteArrayB = new byte[] {227, 161, 117, 89, 112, 65, 187, 178};
            Assert.Equal(3, CompareLastBytes(byteArrayA, byteArrayB).Length);

            // Both arrays are different
            byteArrayB = new byte[] {241, 166, 19, 198};
            Assert.Equal(0, CompareLastBytes(byteArrayA, byteArrayB).Length);

            // One array is empty
            Assert.Equal(0, CompareLastBytes(byteArrayA, new byte[0]).Length);

            // One or more arrays are null
            Assert.Equal(0, CompareLastBytes(null, byteArrayB).Length);
            Assert.Equal(0, CompareLastBytes(byteArrayA, null).Length);
            Assert.Equal(0, CompareLastBytes(null, null).Length);
        }
    }
}