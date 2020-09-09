using System;
using System.IO;
using static CompareBytes.ByteArrayUtils;

namespace CompareBytes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                string filePathA = args[0], filePathB = args[1];

                try
                {
                    byte[] fileABytes = File.ReadAllBytes(filePathA),
                        fileBBytes = File.ReadAllBytes(filePathB);
                    var byteComparison = ByteComparison.CompareBytes(fileABytes, fileBBytes);

                    if (byteComparison.AreIdentical)
                        Console.WriteLine("Las cadenas de bytes son idénticas con una longitud de {0} bytes.",
                            fileABytes.Length);
                    else
                    {
                        Console.WriteLine("{0} bytes coincidientes al principio y {1} al final",
                            byteComparison.IdenticalFirstBytes.Length,
                            byteComparison.IdenticalFinalBytes.Length);

                        Console.WriteLine("Bytes al principio: {0}",
                            ArrayToString(byteComparison.IdenticalFirstBytes, PrintFormat.Hexadecimal));

                        Console.WriteLine("Bytes al final: {0}",
                            ArrayToString(byteComparison.IdenticalFinalBytes, PrintFormat.Hexadecimal));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
            else
            {
                Console.WriteLine("Se necesitan dos argumentos, " +
                                  "los cuales deben ser las rutas de los archivos a analizar");
            }
        }
    }
}