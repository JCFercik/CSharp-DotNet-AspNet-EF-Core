using System;

namespace AppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Craindo e atribuindo valores ao array
            int[] intArray = new int[5] { 1, 2, 3, 4, 5 }; 
            object[] objArray = new object[5] { 15, 20, 25, 30, 35 };
            
            // Acessando uma posição pelo índice
            Console.WriteLine(intArray[1]);

            // Percorrendo os elementos do array (int e object)
            Console.WriteLine(">>> Array de inteiros (int)");
            foreach(int i in intArray)
            {
                Console.WriteLine($"\t# {i}");
            }
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine(">>> Array de inteiros (object)");
            foreach(object i in objArray)
            {
                Console.WriteLine($"\t# {i}");
            }
            Console.WriteLine("----------------------------------------------------------------------------");

            // Usando a função COPY para copiar elementos entre um array de inteiros e um array object.
            // Copiando os 2 primeiros elementos do array de inteiros para o object array
            Array.Copy(intArray, objArray, 2);

            Console.WriteLine(">>> Copiando as 2 primeiras posições do int para o object");
            foreach (object i in objArray)
            {                
                Console.WriteLine($"\t# {i}");
            }
            Console.WriteLine("----------------------------------------------------------------------------");

            // Copiando os 2 últimos elementos do array object para o array de inteiros
            Array.Copy(objArray, objArray.GetUpperBound(0) - 1, intArray, intArray.GetUpperBound(0) - 1, 2);

            Console.WriteLine(">>> Copiando os 2 últimos elementos do array object para o array de inteiros");
            foreach(int i in intArray)
            {
                Console.WriteLine($"\t# {i}");
            }
            Console.WriteLine("----------------------------------------------------------------------------");

            // Criando e inicializando arrays multidimensional
            // Array com 2 dimensões
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // Definindo as domensões do array
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // Um array similar com elementos do tipo string
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            // Array com três dimensões
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };




            Console.WriteLine(">>> Array multidimensional");
            Array myArr = Array.CreateInstance(typeof(int), 2, 3, 4);
            for (int i = myArr.GetLowerBound(0); i <= myArr.GetUpperBound(0); i++)
            {
                for (int j = myArr.GetLowerBound(1); j <= myArr.GetUpperBound(1); j++)
                {
                    for (int k = myArr.GetLowerBound(2); k <= myArr.GetUpperBound(2); k++)
                    {
                        myArr.SetValue((i * 100) + (j * 10) + k, i, j, k);
                    }
                }
            }
            // Mostrando as propriedades do array
            Console.WriteLine($"O array têm {myArr.Rank} dimensões e um total de {myArr.Length} elementos.");
            for (int i = 0; i < myArr.Rank; i++)
            {
                Console.Write($"{i}:\t{myArr.GetLength(i)}");
                Console.WriteLine($"\t{myArr.GetLowerBound(i)}\t{myArr.GetUpperBound(i)}");
            }
            Console.WriteLine();
            // Mostrando o conteúdo do array
            Console.WriteLine("O array contém os seguintes valores");
            PrintValues(myArr);


        }
        static void PrintValues(Array myArray)
        {
            System.Collections.IEnumerator myEnumerator = myArray.GetEnumerator();
            int i = 0;
            int cols = myArray.GetLength(myArray.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }

            Console.Read();
        }
    }
}
