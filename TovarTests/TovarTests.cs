using SizovID_01_06.Models;

namespace TovarTests
{
    public class Tests // ����� ������� �� ������
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_Tovar_Good()
        {
            Tovar tovar = new Tovar("������� �������", 1500, 50); // ������� ������� ���� �� ������, ��������� ����� ����� �������� �������� ������
            double expected = 30;
            double actual = tovar.QFunction();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2_Tovar_Bad() // ������������� ����������� �� ������, ������� ��������� �������� ������ ����������
        {
            Tovar tovar = new Tovar("�������������", 2500, 0);
            double expected = 0;
            double actual = tovar.QFunction();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test1_TovarChild_Good() // ��������������� ���� �� ������, ��������� ����� ����� �������� �������� ������
        {
            TovarChild tovar = new TovarChild("��������������", 15000, 10, 2007);
            double expected = 8;
            double actual = tovar.QpFunction();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2_TovarChild_Bad() // ������ ���� �� ������ �� ��� �� ������, ������� ��������� �������� ������ ����������
        {
            TovarChild tovar = new TovarChild("�����", 300, 20, 0);
            double expected = 0;
            double actual = tovar.QpFunction();
            Assert.AreEqual(expected, actual);
        }

    }
}