using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizovID_01_06.Models
{
    public class TovarChild : Tovar // Класс потомок "Товара на складе"
    {
        public double P { get; set; } // Год выпуска товара
        public double Qp { get; set; } // Качество класса потомка


        // Конструктор класса потомка
        public TovarChild(string TovarName, double Price, int Count, double P) : base(TovarName, Price, Count)
        {
            this.P = P;
        }


        public double QpFunction() // Функция класса потомка
        {
            // Условие, если Цена больше 0, количество товара больше 0 и год выпуска товара больше 0
            if (Price > 0 && Count > 0 && P > 0)             {
                Qp = Q + 0.5 * (2023 - P); // Вычисление качества товара класса потомка
                return Qp;
            }
            else // Иначе вернуть значение 0
            {
                return 0;
            }
        }


        public string PrintInfo() // Вывод информации класса потомка "Товар на складе"
        {
            return "\n==========\nКласс потомка товара на складе\n==========\nНазвание товара: " + TovarName
            + "\nЦена: " + Price + " Рублей " 
            + "\nКоличество: " + Count + " Штук"
            + "\nГод выпуска товара: " + P + " Год"
            + "\nКачество: " + Qp
            + "\n==========";
        }
    }
}
