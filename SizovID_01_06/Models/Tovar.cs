using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizovID_01_06.Models
{
    public class Tovar // Базовый класс "Товар на складе"
    {
        public string TovarName { get; set; } // Наименование товара
        public double Price { get; set; } // Цена товара
        public int Count { get; set; } // Количество товара
        public double Q { get; set; } // Качество базового класса


        public Tovar(string TovarName, double Price, int Count) // Конструктор базового класса
        {
            this.TovarName = TovarName;
            this.Price = Price;
            this.Count = Count;
        }


        public double QFunction() // Функция базового класса
        {
            // Условие, если Цена больше 0, количество товара больше 0
            if (Price > 0 && Count > 0)
            {
                Q = Price / Count; // Вычисление качества товара базового класса
                return Q;
            }
            else // Иначе вернуть значение 0
            {
                return 0;
            }
        }


        public string PrintInfo() // Вывод информации базового класса "Товар на складе" 
        {
            return "==========\nБазовый класс товара на складе\n==========\nНазвание товара: " + TovarName
            + "\nЦена: " + Price + " Рублей "
            + "\nКоличество: " + Count + " Штук "
            + "\nКачество: " + Q
            +"\n==========";
        }
    }
}
