using System;
using lab_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Исходные данные для теста.
            //double x1 = 3;
            //double x2 = 7;
            //double y1 = 6;
            //double y2 = 3;

            // Ожидаемое значение 5
            Double experted = 5;

            // Вызов тестируемой функции.
            Form1 form1 = new Form1();
            Double actual = form1.CalcDistance(3, 6, 7, 3);

            Assert.AreEqual(experted, actual, 0.00, "Ожидаемое среднее арифметическое положительных элементов массива не было получено!");

        }

        [TestMethod]
        public void TestMethod2()
        {
            // Исходные данные для теста.
            //double x1 = 3;
            //double x2 = 7;
            //double y1 = 6;
            //double y2 = 3;

            // Ожидаемое значение 2.8284
            Double experted = 2.8284;

            // Вызов тестируемой функции.
            Form1 form1 = new Form1();
            Double actual = form1.CalcDistance(4, 7, 6, 9);

            Assert.AreEqual(experted, actual, 0.00, "Ожидаемое среднее арифметическое положительных элементов массива не было получено!");

        }

        [TestMethod]
        public void TestMethod3()
        {
            // Ожидаемое значение 12
            Double experted = 12;

            // Вызов тестируемой функции.
            Form1 form1 = new Form1();
            Double actual = form1.CalcPerimeter(3, 6, 7, 3);

            Assert.AreEqual(experted, actual, 0.00, "Ожидаемое среднее арифметическое положительных элементов массива не было получено!");
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Ожидаемое значение 5
            Double experted = 6.8284;

            // Вызов тестируемой функции.
            Form1 form1 = new Form1();
            Double actual = form1.CalcPerimeter(4, 7, 6, 9);

            Assert.AreEqual(experted, actual, 0.00, "Ожидаемое среднее арифметическое положительных элементов массива не было получено!");
        }
    }
}
