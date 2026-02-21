using System;

namespace SiyaLangAngGustoKo.Services;
{
    public class InventoryService
    {
        private String[,] products;
        private int[] stock;
        
        public InventoryService()
        {
            products = new String[2, 3];
            
            // product names ni sa row 0 sir
            
            products[0, 0] = "Fuji Apple";
            products[0, 1] = "BearBrand";
            products[0, 2] = "Malunggay Pandesal";
            
            // product quantity ni sir naa sa row 1
            
            products[1, 0] = "10";
            products[1, 1] = "5";
            products[1, 2] = "20";
            
            stock = new int[3];
            
            for(int i = 0; i < 3; i++)
            {
                stock[i] = int.Parse(products[1, i]);
            }
            
        }
        
        public string[,] GetInventory()
        {
            return products;
        }
        
        public void UpdateStock(int productPos, int newStock)
        {
            products[1, productPos ] = newStock.ToString();
        }
        
        public void ResetInventory()
        {
            for(int i = 0; i < stock.length; i++)
            {
                products[1, i] = stock[i].ToString();
            }
        }
    }
}
