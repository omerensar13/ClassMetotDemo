using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CostumerManager
    {
        public void  AddCostumer (Costumer costumer)
        {
            Console.WriteLine(costumer.Name + "  " + costumer.Surname + " sisteme eklendi!  ");
        }
        public void DeleteCostumer (Costumer costumer)
        {
            Console.WriteLine(costumer.Name + "  " + costumer.Surname + " sistemden silindi!  ");
        }
        public void ListCostumer (Costumer[] costumers)
        {

            foreach (var costumer in costumers)
            {
                Console.WriteLine(costumer.Id);
                Console.WriteLine(costumer.Name);
                Console.WriteLine(costumer.Surname);
                Console.WriteLine(costumer.PhoneNumber);
                Console.WriteLine(costumer.Adress);
            }

         }


    
    }
}
