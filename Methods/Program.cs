using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Costumer costumer1 = new Costumer();
            costumer1.Id = 1;
            costumer1.Name = "Adem";
            costumer1.Surname = "Oğlu";
            costumer1.PhoneNumber = 05366987898;

            Costumer costumer2 = new Costumer();
            costumer2.Id = 2;
            costumer2.Name = "Havva";
            costumer2.Surname = "Oğlu";
            costumer2.PhoneNumber = 0536698995;

            Costumer costumer3 = new Costumer();
            costumer3.Id = 3;
            costumer3.Name = "Habil";
            costumer3.Surname = "Oğlu";
            costumer3.PhoneNumber = 05866927818;

            Costumer[] costumers = new Costumer[] {costumer1,costumer2,costumer3 };

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.AddCostumer(costumer1);
            costumerManager.AddCostumer(costumer2);
            costumerManager.AddCostumer(costumer3);
            costumerManager.ListCostumer(costumers);
            costumerManager.DeleteCostumer(costumer1);
            costumerManager.DeleteCostumer(costumer2);
            costumerManager.DeleteCostumer(costumer3);




        }
    }
}
