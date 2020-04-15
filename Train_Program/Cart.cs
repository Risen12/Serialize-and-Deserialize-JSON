using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Program
{
    class Cart
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList <Product> Contents {get;set;}
        public bool OrderCompleted { get; set; }
        public override string ToString()
        {
            string products = "";
            for (int i = 0; i < Contents.Count; i++)
            {
                products += "ID товара: " + Contents[i].ProductID + "; Название товара: " + Contents[i].ProductName + "; Количество товара: " + Contents[i].Quantity + "\n";
            }
            return @"Номер заказа: " + OrderID + "\n"
                   + "Имя заказчика: " + Name + "\n"
                   + "Email заказчика: " + Email + "\n"
                   + "Имя заказчика: " + Name + "\n" +
                   products + "Выполнение заказа: " + Convert.ToString(OrderCompleted);
        }
    }
}
