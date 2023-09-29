using System;

namespace Laba3_V_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 939:");
            Task_939();
            Console.WriteLine();

            Console.WriteLine("Задание 946");
            Task_946();
            Console.WriteLine();

            Console.WriteLine("Задание 965");
            Task_965();
            Console.WriteLine();

            Console.WriteLine("Задание 1002");
            Task_1002();
            Console.WriteLine();

        }
        /// <summary>
        /// Известен номер столбца, на котором расположен элемент побочной диагонали массива. 
        /// Вывести на экран значение этого элемента.
        /// </summary>
        private static void Task_939()
        {
            Random random = new();
            int rows = 6;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                    Console.Write(matrix[i, j]+"  \t");

                }
                Console.WriteLine();
            }
            int indexRandomColum = random.Next(0, columns - 1);
            Console.Write("Елемент росположеный в "+(indexRandomColum+1) + "-ом столбце и расположенный на побочной диагонале = " + matrix[rows-indexRandomColum-1,indexRandomColum]);
        }
        /// <summary>
        ///  В массиве записаны целые числа. Вычислить:
        ///а) сумму элементов главной диагонали массива, больших 20;
        ///б) сумму элементов побочной диагонали массива, кратных четырем;
        ///в) количество элементов побочной диагонали массива, равных пяти;
        ///г) число четных элементов главной диагонали массива.
        ///д) произведение элементов побочной диагонали массива, меньших 10;
        ///е) сумму элементов главной диагонали массива, оканчивающихся цифрой 7;
        ///ж) количество нулевых элементов главной диагонали массива;
        ///з) число нечетных элементов побочной диагонали массива.
        /// </summary>
        private static void Task_946()
        {
            Random random = new();
            int rows = 5;
            int columns = 5;
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                    Console.Write(matrix[i, j] + "  \t");

                }
                Console.WriteLine();
            }
            int sumElementsOnMainDiagonalMoreConst = 0;
            int sumElementsOnSideDiagonalMultipleConst = 0;
            int countElementsOnSideDiagonalEqualConst = 0;
            int countElementsOnMainDiagonalEven = 0;
            int productElementsOnSideDiagonalLessConst = -1;
            int sumElementsOnMainDiagonalEndingConst = 0;
            int countElementsOnMainDiagonalEqualZero = 0;
            int countElementsOnSideDiagonalUnEven = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(i==j )
                    {
                        if( matrix[i, j] > 20)
                        {
                            sumElementsOnMainDiagonalMoreConst += matrix[i, j];
                        }
                        if(matrix[i,j]%2 == 0)
                        {
                            countElementsOnMainDiagonalEven++;
                        }
                        if(matrix[i,j]%10 == 7)
                        {
                            sumElementsOnMainDiagonalEndingConst += matrix[i, j];
                        }
                        if (matrix[i,j] == 0)
                        {
                            countElementsOnMainDiagonalEqualZero++;
                        }
                        
                    }
                    if (i + j == rows - 1 )
                    {
                        if (matrix[i, j] % 4 == 0)
                        {
                            sumElementsOnSideDiagonalMultipleConst += matrix[i, j];
                        }
                        if (matrix[i, j] == 5)
                        {
                            countElementsOnSideDiagonalEqualConst++;
                        }
                        if (matrix[i, j] < 10)
                        {
                            productElementsOnSideDiagonalLessConst *= matrix[i, j];
                        }
                        if(matrix[i,j] %2 == 1)
                        {
                            countElementsOnSideDiagonalUnEven++;
                        }
                    };
                }
            }
            Console.WriteLine("a)сумма элементов главной диагонали массива, больших 20 = "+sumElementsOnMainDiagonalMoreConst);
            Console.WriteLine("б)сумма элементов побочной диагонали массива, кратных четырем = " + sumElementsOnSideDiagonalMultipleConst); 
            Console.WriteLine("в)количество элементов побочной диагонали массива, равных пяти = " + countElementsOnSideDiagonalEqualConst);
            Console.WriteLine("г)число четных элементов главной диагонали массива = " + countElementsOnMainDiagonalEven);
            string resD = "";
            if(productElementsOnSideDiagonalLessConst == -1)
            {
                resD = "нет елементов меньше 10";
            }
            else
            {
                productElementsOnSideDiagonalLessConst = -productElementsOnSideDiagonalLessConst;
                resD = "" + productElementsOnSideDiagonalLessConst;
            }
            Console.WriteLine("д)произведение элементов побочной диагонали массива, меньших 10 = " + resD);
            Console.WriteLine("е) сумму элементов главной диагонали массива, оканчивающихся цифрой 7 = " + sumElementsOnMainDiagonalEndingConst);
            Console.WriteLine("ж) количество нулевых элементов главной диагонали массива = " + countElementsOnMainDiagonalEqualZero);
            Console.WriteLine("з) число нечетных элементов побочной диагонали массива = " + countElementsOnSideDiagonalUnEven);
        }
        /// <summary>
        /// В Двумерном массиве хранится информация о зарплате 18 человек за каждый месяц года 
        /// (за январь — в первом столбце, за февраль — во втором и т. д.). 
        /// Определить общую зарплату, выплаченную в июне.
        /// </summary>
        private static void Task_965()
        {
            Random random = new();
            int rowsPeople = 18;
            int columnsMonth = 12;
            int[,] matrix = new int[rowsPeople, columnsMonth];
            Console.WriteLine("Информация о зарплате 18 человек за каждый месяц года");
            for (int i = 0; i < rowsPeople; i++)
            {
                for (int j = 0; j < columnsMonth; j++)
                {
                    matrix[i, j] = random.Next(1000, 15000);
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            int indexJune = 5;
            int sumElements = 0;

            for (int i = 0; i < rowsPeople; i++)
            {
                sumElements += matrix[i, indexJune ];
            }

            Console.WriteLine("Общая зарплата, выплаченная в июне ="+sumElements);
        }
        /// <summary>
        /// Заданы матрица порядка n и число k.Разделить элементы k-й строки на диагональный элемент, 
        ///расположенный в этой строке.
        /// </summary>
        private static void Task_1002()
        {
            Random random = new();
            int orderMatrix = random.Next(3,10);

            float[,] matrix = new float[orderMatrix, orderMatrix];
            Console.WriteLine("Матрица до:");
            for (int i = 0; i < orderMatrix; i++)
            {
                for (int j = 0; j < orderMatrix; j++)
                {
                    matrix[i, j] = (float)random.NextDouble() * 100;
                    Console.Write($"{matrix[i, j]} \t");

                }
                Console.WriteLine();

            }
            int k = random.Next(0,orderMatrix-1);
            float elementOnMainDiagonal = matrix[k, k];
            Console.WriteLine("K(индекс строки)="+k);
            for (int j = 0; j < orderMatrix; j++)
            {
                matrix[k, j] = matrix[k, j]/ elementOnMainDiagonal;
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Матрица после:");
            for (int i = 0; i < orderMatrix; i++)
            {
                for (int j = 0; j < orderMatrix; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");

                }
                Console.WriteLine();
            }
            
        }

    }
}
