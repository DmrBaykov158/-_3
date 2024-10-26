

namespace LibMas
{
    public class Class1
    {

        /// <summary>
        /// ��������� ������ ���������� ������ �������
        /// </summary>
        /// <param name="rows">���-�� �����</param>
        /// <param name="columns">���-�� ��������</param>
        /// <returns>���������� ����������� �������</returns>
        public static int[,] FillArray(int rows, int columns)
        {

            Random random = new Random(); // ������� ������ ��� ��������� ��������� �����

            int[,] matrix = new int[rows, columns]; // ������� ������� ��������� �������

            for (int i = 0; i < rows; i++) // ��������� ������� ���������� �������
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-100, 101); // ��������� ����� �� -100 �� 100
                }
            }
            return matrix; // ���������� ����������� �������
        }


        /// <summary>
        /// ������� ������ �� �����
        /// </summary>
        /// <param name="matrix">�������</param>
        public static void PrintArray(int[,] matrix)
           
        {
            Console.WriteLine("�������:"); // ������� ���������
            for (int i = 0; i < matrix.GetLength(0); i++) // �������� �� ���� ��������� �������
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " "); // ������� ������� �������
                }
                Console.WriteLine();
            }
        }
    }

}
