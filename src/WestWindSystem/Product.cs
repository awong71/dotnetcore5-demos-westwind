using System;

namespace WestWindSystem
{
    public class Product
    {
        #region Ex01
        public readonly string ProductName;
        public readonly Category Category;
        public readonly string QuantityPerUnit;
        public readonly int MinimumOrderQuantity;
        public readonly int UnitPrice;
        public readonly int UnitsOnOrder;
        public readonly bool Discontinued;

        private const string SPECIALCHARACTERS =@",:;\/!?@#$%^&*~`";

        public Product(string productName, Category category, string quantityPerUnit,
            int minimumOrderQuantity, int unitPrice, int unitsOnOrder, bool discontinued)
        {
            if (string.IsNullOrEmpty(productName)) 
                throw new ArgumentNullException("Product Name cannot be null or empty");
            foreach(var character in SPECIALCHARACTERS)
                if (productName.Contains(character))
                    throw new FormatException($"Product Name contains an invalid character.");
            
            ProductName = productName.Trim();
            Category = category;
            QuantityPerUnit = quantityPerUnit;
            MinimumOrderQuantity = minimumOrderQuantity;
            UnitPrice = unitPrice;
            UnitsOnOrder = unitsOnOrder;
            Discontinued = discontinued;
        }

        public override string ToString()
       {
           return $"{ProductName},{Category},{QuantityPerUnit},{MinimumOrderQuantity},{UnitPrice},{UnitsOnOrder},{Discontinued}";
       }
       #endregion

        #region Ex02
        public static Product Parse(string text)
        {
            string [] items = text.Split(',');
            if (items.Length != 7) 
                throw new FormatException("Input string is not the correct CSV format" );
            return new Product(
                items[0],
                (Category)Enum.Parse(typeof(Category), items[1]),
                items[2],
                int.Parse(items[3]),
                int.Parse(items[4]),
                int.Parse(items[5]),
                bool.Parse(items[6])
            );
        }
        public static bool TryParse(string text, out Product result)
        {
            bool valid = false;
            try
            {
                result = Parse(text);
                valid = true;
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"catch Product.TryParse: {ex.Message}");  
                result = null;
            }
            return valid;
        }
       #endregion
    }
}