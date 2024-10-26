using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibMas;
using Lib_1;

namespace Прак_3
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                int m = int.Parse(InputRows.Text);
                int n = int.Parse(InputColumns.Text);
                int k = int.Parse(InputK.Text);

                int[,] matrix = Class1.FillArray(m, n); // Создаем матрицу и заполняем ее случайными числами
                Class1.PrintArray(matrix); // Вывод матрицы

                

                (int sum, int product) = Class2.CalculateRow(matrix, k); // Вычисляем сумму и произведение элементов K строки
                ResultTextBlock.Text = $"Сумма элементов {k}-й строки: {sum}\n" +
                    $"Произведение элементов {k}-й строки: {product}"; // Выводим результат в текстовый блок
                ResultMatrix.Text = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j=0; j< matrix.GetLength(1); j++)
                    {
                        ResultMatrix.Text = ResultMatrix.Text + matrix[i, j].ToString() + " ";
                    }
                    ResultMatrix.Text = ResultMatrix.Text + "\n";



                }
             
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных.", "Ошибка"); // Выводим сообщение об ошибке, если ввод некорректный
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close(); // Закрываем окно
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Выводим информацию о программе в диалоговое окно
            MessageBox.Show("Разработчик: Байков Дмитрий\n" +
                "Номер работы: 3\n" +
                "Задание: Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Найти сумму и произведение элементов K-й строки данной матрицы.", "О программе");
        }

    }
}
