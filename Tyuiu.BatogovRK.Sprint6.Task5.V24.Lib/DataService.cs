using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BatogovRK.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public double[] LoadFromDataFile(string path)
        {
            {
                double[] array = Array.ConvertAll(File.ReadAllLines(path), x => Convert.ToDouble(x));
                double[] res = new double[array.Count(x => x == 0)];
                for (int i = 0, x = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        res[x] = array[i];
                        x++;
                    }
                }
                return res;
            }
        }
    }
}
