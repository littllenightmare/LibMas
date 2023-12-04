using System;
using System.IO;

namespace LibMas
{
    public class Massiv
    {
        /// <summary>
        /// ���������� ������� ��������
        /// </summary>
        /// <param name="mas">��� ������</param>
        /// <param name="column">���������� �����</param>
        /// <param name="randMax">������������ ����� ��� �������</param>
        public static void InitMas(out int[] mas, int column, int randMax)
        {
            Random random = new Random();
            mas = new int[column];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(randMax);
            }
        }
        /// <summary>
        /// ������������ ��������� �������
        /// </summary>
        /// <param name="mas">��� ������</param>
        /// <returns>����� ���� ��������� �������</returns>
        public static int SumMas(int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }
        /// <summary>
        /// ������� ��� ������ ������� � ����
        /// </summary>
        /// <param name="mas">������</param>
        public static void SaveMas(int[] mas)
        {
            StreamWriter sw = new StreamWriter("������.txt");
            sw.WriteLine(mas.Length);
            for (int i = 0; i < mas.Length; i++)
            {
                sw.WriteLine(mas[i]);
            }
            sw.Close();
        }
        /// <summary>
        /// ������� ��� �������� ������� �� �����
        /// </summary>
        /// <param name="mas">������</param>
        public static void OpenMas(out int[] mas)
        {
            StreamReader sr = new StreamReader("������.txt");
            int len = Convert.ToInt32(sr.ReadLine());
            mas = new int[len];
            for (int i = 0; i < len; i++)
            {
                mas[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
        }
        /// <summary>
        /// ������� ��� ������ ������� � ������
        /// </summary>
        /// <param name="matr">�������</param>
        public static void SaveMatr(int[,] matr)
        {
            StreamWriter sw = new StreamWriter("�������.txt");
            int rows = matr.GetLength(0);
            int columns = matr.GetLength(1);
            sw.WriteLine($"{rows}");
            sw.WriteLine($"{columns}");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sw.Write(matr[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
        /// <summary>
        /// ������� ��� ������ ������� �� �����
        /// </summary>
        /// <param name="matr">�������</param>
        public static void OpenMatr(out int[,] matr)
        {
            StreamReader sr = new StreamReader("�������.txt");
            int rows = Convert.ToInt32(sr.ReadLine());
            int columns = Convert.ToInt32(sr.ReadLine());
            matr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    matr[i, j] = int.Parse(line[j]);
                }
            }
            sr.Close();
        }
    }
}
