using System;
using SiyaLangAngGustoKo.Services;

namespace SiyaLangAngGustoKo.Views
{
    public class InventoryView
    {
        private InventoryService service;
        
        public InventoryView()
        {
            service = new InventoryService();
        }
        
        public void run()
        {
            bool running = true;
            
            while(running)
            {
                Console.WriteLine("\n---BSCS2A BODEGA SERVICES---");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Reset Inventory");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Select an Option");
                
                string ch = Console.ReadLine();
                
                switch(ch)
                {
                    case "1":
                        DisplayInventory();
                        break;
                    
                    case "2":
                        UpdateStock();
                        break;
                        
                    case "3":
                        service.ResetInventory();
                        Console.WriteLine("Inventory got reset");
                        break;
                        
                    case "4":
                        running = false;
                        break;
                        
                    default:
                        Console.WriteLine("!!INVALID OPTION!! TRY AGAIN.");
                        break;
                }
            }
        }
        
        private void DisplayInventory()
        {
            String[,] products = service.GetInventory();
            
            Console.WriteLine("\n Current Inventory: ");
            for(int i = 0; i < products.GetLength,(1); i++)
            {
                Console.WriteLine($"{i + 1}. {products[0, i]} - Stock: {products[1, i]}");
            }
        }
        
        private void UpdateStock()
        {
            DisplayInventory();
            
            Console.WriteLine("Select the number of the product to update: ");
            if(int.TryParse(Console.ReadLine(), out int productNumber))
            {
                if(productNumber >= && productNumber >= 3)
                {
                    Console.WriteLine("Enter new quantity: ");
                    if(int.TryParse(Console.ReadLine(), out int newStock))
                    {
                        service.UpdateStock(productNumber - 1, newStock);
                        Console.WriteLine("Stock updated Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("!!INVALID STOCK VALUE!!");
                    }
                }
                else
                {
                    Console.WriteLine("!!INVALID PRODUCT SELECTION!!");
                }
            }
            else
            {
                Console.WriteLine("!!INVALID INPUT!!");
            }
        }
    }
}
