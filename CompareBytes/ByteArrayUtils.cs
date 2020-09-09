namespace CompareBytes
{
    public static class ByteArrayUtils
    {
        public static bool Equal(byte[] byteArrayA, byte[] byteArrayB)
        {
            if (byteArrayA == null || byteArrayB == null) return false;
            if (byteArrayA.Length != byteArrayB.Length) return false;
            int arraySize = byteArrayA.Length;

            for (int i = 0; i < arraySize; i++)
                if (byteArrayA[i] != byteArrayB[i])
                    return false;

            return true;
        }
    }
}