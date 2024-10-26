

namespace Lib_1
{
    public class Class2
    {

        /// <summary>
        /// ������� ����� � ������������ ��������� K ������ �������
        /// </summary>
        /// <param name="matrix">�������</param>
        /// <param name="k">����� ������</param>
        /// <returns>���������� ����� � ������������</returns>
        public static (int sum, int product) CalculateRow(int[,] matrix, int k)
        {
            int sum = 0;
            int product = 1;
            for (int j = 0; j < matrix.GetLength(1); j++) // �������� �� ��������� K ������ �������
            {
                sum += matrix[k - 1, j];  // ��������� ������� ������� � �����
                product *= matrix[k - 1, j]; // �������� ������� ������� �� ������������
            }
            return (sum, product); // ���������� ����� � ������������
        }
    }

}
