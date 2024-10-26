

namespace LibMas
{
    public class Class1
    {

        /// <summary>
        /// Заполняет массив случайными целыми числами
        /// </summary>
        /// <param name="rows">Кол-во строк</param>
        /// <param name="columns">Кол-во столбцов</param>
        /// <returns>Возвращаем заполненную матрицу</returns>
        public static int[,] FillArray(int rows, int columns)
        {

            Random random = new Random(); // Создаем объект для генерации случайных чисел

            int[,] matrix = new int[rows, columns]; // Создаем матрицу заданного размера

            for (int i = 0; i < rows; i++) // Заполняем матрицу случайными числами
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-100, 101); // Случайные числа от -100 до 100
                }
            }
            return matrix; // Возвращаем заполненную матрицу
        }


        /// <summary>
        /// Выводит массив на экран
        /// </summary>
        /// <param name="matrix">Матрица</param>
        public static void PrintArray(int[,] matrix)
           
        {
            Console.WriteLine("Матрица:"); // Выводим заголовок
            for (int i = 0; i < matrix.GetLength(0); i++) // Проходим по всем элементам матрицы
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " "); // Выводим текущий элемент
                }
                Console.WriteLine();
            }
        }
    }

}
