using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.TitkovAA.Sprint7.Project.V10.Lib
{
    public class DataService
    {

        public double Max(string[,] path)
        {
            double max = 0;
            int column = 6;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, column]) > max)
                {
                    max = Convert.ToDouble(path[i, column]);
                }
            }
            return max;
        }
        public double Min(string[,] path)
        {
            double min = int.MaxValue;
            int column = 6;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, column]) < min)
                {
                    min = Convert.ToDouble(path[i, column]);
                }
            }
            return min;
        }
        public double Avg(string[,] path)
        {
            double sum = 0;

            for (int i = 1; i < path.GetLength(0); i++)
            {
                sum += Convert.ToDouble(path[i, 6]);
            }
            double average = sum / (path.GetLength(0) - 1);
            return Math.Round(average, 2);
        }

        public string[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows, cols;
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            string[,] arrstr = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] prikol = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrstr[i, j] = Convert.ToString(prikol[j]);
                }
            }
            return arrstr;
        }

    }
}
