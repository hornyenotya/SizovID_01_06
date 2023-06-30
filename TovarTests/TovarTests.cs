using SizovID_01_06.Models;

namespace TovarTests
{
    public class Tests // Тесты товаров на складе
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_Tovar_Good()
        {
            Tovar tovar = new Tovar("Игровая консоль", 1500, 50); // Игровые консоле есть на складе, благодаря этому можно вычеслит качество товара
            double expected = 30;
            double actual = tovar.QFunction();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2_Tovar_Bad() // Микроволновки отсутствуют на складе, поэтому вычеслить качество товара невозможно
        {
            Tovar tovar = new Tovar("Микроволновка", 2500, 0);
            double expected = 0;
            double actual = tovar.QFunction();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test1_TovarChild_Good() // Электросамокаты есть на складе, благодаря этому можно вычеслит качество товара
        {
            TovarChild tovar = new TovarChild("Электросамокат", 15000, 10, 2007);
            double expected = 8;
            double actual = tovar.QpFunction();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2_TovarChild_Bad() // Пульты есть на складе но год не указан, поэтому вычеслить качество товара невозможно
        {
            TovarChild tovar = new TovarChild("Пульт", 300, 20, 0);
            double expected = 0;
            double actual = tovar.QpFunction();
            Assert.AreEqual(expected, actual);
        }

    }
}