

namespace Lib_1
{
    public class Class2
    {

        /// <summary>
        /// Находит сумму и произведение элементов K строки матрицы
        /// </summary>
        /// <param name="matrix">матрица</param>
        /// <param name="k">номер строки</param>
        /// <returns>Возвращаем сумму и произведение</returns>
        public static (int sum, int product) CalculateRow(int[,] matrix, int k)
        {
            int sum = 0;
            int product = 1;
            for (int j = 0; j < matrix.GetLength(1); j++) // Проходим по элементам K строки матрицы
            {
                sum += matrix[k - 1, j];  // Добавляем текущий элемент к сумме
                product *= matrix[k - 1, j]; // Умножаем текущий элемент на произведение
            }
            return (sum, product); // Возвращаем сумму и произведение
        }
    }

}
