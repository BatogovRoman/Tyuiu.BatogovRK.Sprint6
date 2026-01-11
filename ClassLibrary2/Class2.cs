namespace ClassLibrary2
{
    public class Class2
    {
        public int[,] GetMatrix(int[,] array, int n1, int n2)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            Random rn = new Random();


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j % 2 == 0)
                    {
                        array[i, j] = Math.Abs(rn.Next(n1, n2));
                    }
                    else
                    {
                        array[i, j] = -1*Math.Abs(rn.Next(n1, n2));
                    }
                }
            }
            return array;
        }

        public int result(int[,] array, int c, int k, int l)
        {
            int sum = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int element = array[i, j];

                    if (element > 0)
                    {
                        if (j == c && i >= k && i <= l)
                        {
                            continue;
                        }
                        sum += element;
                    }
                }
            }
            return sum;
        }
    }
}