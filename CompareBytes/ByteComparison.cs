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
    }
}