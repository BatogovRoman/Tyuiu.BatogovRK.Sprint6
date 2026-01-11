using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
        public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            // Проверка
            if (n1 >= n2)
                throw new ArgumentException("n1 должно быть меньше n2 (n1 < n2)");

            if (k >= l)
                throw new ArgumentException("k должно быть меньше l (k < l)");

            if (c < 0 || c >= array.GetLength(1))
                throw new ArgumentException($"c должно быть в диапазоне [0, {array.GetLength(1) - 1}]");

            if (k < 0 || l < 0)
                throw new ArgumentException("k и l должны быть неотрицательными");

            if (k >= array.GetLength(0) || l >= array.GetLength(0))
                throw new ArgumentException($"k и l должны быть в диапазоне [0, {array.GetLength(0) - 1}]");

            ArgumentNullException.ThrowIfNull(array);

            if (array.GetLength(0) <= 1 || array.GetLength(1) <= 1)
                throw new ArgumentException("Размеры массива должны быть больше 1 (N>1, M>1)");

            int sum = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            // Сумма с искл
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int element = array[i, j];

                    // Проверка x>0
                    if (element > 0)
                    {
                        // Искл или нет
                        if (j == c && i >= k && i <= l)
                        {
                            continue; // добавляем в сумму
                        }

                        sum += element;
                    }
                }
            }
            return sum;
        }
        public int result(int[,] array, int R, int k, int l)
            {
                int res = 0;
                for (int j = k; j <= l; j++)
                {
                    if (array[R - 1, j] % 2 != 0)
                    {
                        res += array[R - 1, j];
                    }
                }
                return res;
            }
        }
    }
}
