namespace CompareBytes
{
    public static class ByteArrayUtils
    {
        public enum PrintFormat
        {
            Decimal,
            Hexadecimal
        }

        public static string ArrayToString(byte[] byteArray, PrintFormat printFormat = PrintFormat.Decimal)
        {
            var stringBuilder = new System.Text.StringBuilder();

            for (int i = 0; i < byteArray.Length; i++)
            {
                if (printFormat == PrintFormat.Hexadecimal)
                    stringBuilder.Append(byteArray[i].ToString("x2"));
                else
                    stringBuilder.Append(byteArray[i].ToString("D"));

                // Add space separator
                if (i + 1 < byteArray.Length) stringBuilder.Append(' ');
            }

            return stringBuilder.ToString();
        }

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