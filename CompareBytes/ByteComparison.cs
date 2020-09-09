namespace CompareBytes
{
    public class ByteComparison
    {
        public bool AreIdentical { get; set; }
        public byte[] IdenticalFirstBytes { get; set; }
        public byte[] IdenticalFinalBytes { get; set; }

        public static byte[] CompareFirstBytes(byte[] byteArrayA, byte[] byteArrayB)
        {
            if (byteArrayA == null || byteArrayB == null) return new byte[0];

            byte[] resultArray;
            int count;
            if (byteArrayA.Length > byteArrayB.Length)
            {
                for (count = 0; count < byteArrayB.Length; count++)
                    if (byteArrayA[count] != byteArrayB[count])
                        break;
            }
            else
            {
                for (count = 0; count < byteArrayA.Length; count++)
                    if (byteArrayA[count] != byteArrayB[count])
                        break;
            }

            resultArray = new byte[count];
            for (int j = 0; j < count; j++)
                resultArray[j] = byteArrayA[j];

            return resultArray;
        }
        
        public static byte[] CompareLastBytes(byte[] byteArrayA, byte[] byteArrayB)
        {
            if (byteArrayA == null || byteArrayB == null) return new byte[0];

            byte[] resultArray;
            int count;
            if (byteArrayA.Length > byteArrayB.Length)
            {
                for (count = 0; count < byteArrayB.Length; count++)
                    if (byteArrayA[byteArrayA.Length - count - 1] != byteArrayB[byteArrayB.Length - count - 1])
                        break;
            }
            else
            {
                for (count = 0; count < byteArrayA.Length; count++)
                    if (byteArrayA[byteArrayA.Length - count - 1] != byteArrayB[byteArrayB.Length - count - 1])
                        break;
            }

            resultArray = new byte[count];
            for (int j = 0; j < count; j++)
                resultArray[count - j - 1] = byteArrayA[byteArrayA.Length - j - 1];

            return resultArray;
        }
    }
}