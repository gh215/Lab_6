using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_6
{
    public partial class Form1 : Form
    {
        private string fTXT;
        private string file;
        private Stream stm;
        private OpenFileDialog ofd = new OpenFileDialog();
        // Declare a new memory stream.
        MemoryStream userInput = new MemoryStream();


        public Form1()
        {
            InitializeComponent();
        }

        // метод принимает 4 аргумента - 2 точки координат, 
        // вычисляет и возвращает расстояни между двумя точками
        public double CalcDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);
        }

        // Метод CalcPerimeter принимает 4 аргумента - 2 точки координат, которые являются координатами точек
        // и вычисляет и возвращает периметр полученной фигуры из двух точек
        public double CalcPerimeter(double x1, double y1, double x2, double y2)
        {
            double a = (x2 - x1);
            double b = (y2 - y1);
            double c = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);
            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            double perimeter = a + b + c;
            return perimeter;
        }

        // Закрытие файла
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxFileContents.Text = null;
            TextBoxDistance.Text = null;
            TextBoxPerimeter.Text = null;
        }

        // Открытие файла
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            //Stream stm;
            //OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if ((stm = ofd.OpenFile()) != null)
                {
                    file = ofd.FileName;
                    fTXT = File.ReadAllText(file);
                    TextBoxFileContents.Text = fTXT;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // как сохранять без создания нового файла
        }

        //void SaveFile(string whatSave, string whereSave)
        //{
        //    if (whatSave.Count() > 1)
        //    {
        //        if (File.Exists(whereSave))
        //        {
        //            File.Create(whereSave).Close();
        //        }
        //        File.WriteAllText(whatSave, whatSave);
        //    }
        //}

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "txt"; // формат файла
            // возможные варианты формата файла для сохранения
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine(TextBoxFileContents.Text);
                    sw.Close();
                }
            }
        }

        private void BtnCalcPerimeter_Click(object sender, EventArgs e)
        {
            // открываем поток
            StreamReader sr = new StreamReader(ofd.FileName);
            int[] X1 = new int[100];
            int[] Y1 = new int[100];
            int[] X2 = new int[100];
            int[] Y2 = new int[100];
            //string[] el = new string[100];
            int i = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                // разделяем строку по пробелу на символы и кладем их в массив\
                string[] el = line.Split(' ');

                X1[i] = Convert.ToInt32(el[0]);
                Y1[i] = Convert.ToInt32(el[1]);
                X2[i] = Convert.ToInt32(el[2]);
                Y2[i] = Convert.ToInt32(el[3]);
                // TextBoxFileContents.Text += X1[i] + " " + Y1[i] + " " + X2[i] + " " + Y2[i] + "\n";
                int pointX1 = Convert.ToInt32(X1[i]);
                int pointY1 = Convert.ToInt32(Y1[i]);
                int pointX2 = Convert.ToInt32(X2[i]);
                int pointY2 = Convert.ToInt32(Y2[i]);

                // в переменную записываем результат метода CalcPerimeter, которому передаем 2 точки координат
                double c = CalcPerimeter(pointX1, pointY1, pointX2, pointY2);

                // выводим содержимое файла на экран
                TextBoxPerimeter.Text += i + ") " + c + "\n";
                i++;
            }
            // закрываем поток
            sr.Close();
        }

        private void BtnCalcDistance_Click(object sender, EventArgs e)
        {
            // открываем поток
            StreamReader sr = new StreamReader(ofd.FileName);
            int[] X1 = new int[100];
            int[] Y1 = new int[100];
            int[] X2 = new int[100];
            int[] Y2 = new int[100];
            int i = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                // разделяем строку по пробелу на символы и кладем их в массив
                string[] el = line.Split(' ');

                X1[i] = Convert.ToInt32(el[0]);
                Y1[i] = Convert.ToInt32(el[1]);
                X2[i] = Convert.ToInt32(el[2]);
                Y2[i] = Convert.ToInt32(el[3]);
                //TextBoxFileContents.Text += X1[i] + " " + Y1[i] + " " + X2[i] + " " + Y2[i] + "\n";

                int pointX1 = Convert.ToInt32(X1[i]);
                int pointY1 = Convert.ToInt32(Y1[i]);
                int pointX2 = Convert.ToInt32(X2[i]);
                int pointY2 = Convert.ToInt32(Y2[i]);

                // в переменную записываем результат метода CalcDistance, которому передаем 2 точки координат
                double c = CalcDistance(pointX1, pointY1, pointX2, pointY2);

                // выводим содержимое файла на экран
                TextBoxDistance.Text += i + ") " + c + "\n";
                i++;
            }
            // закрываем поток
            sr.Close();
        }
    }
}
