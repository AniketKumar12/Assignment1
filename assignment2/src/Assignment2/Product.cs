using System;
using System.Collections.Generic;

namespace Assignment
{
   public  class Product
    {
        string ProdutName{get;set;}
        double ProdutPrice{get;set;}
        int ProdutQuantity{get;set;}
        string ProdutType{get;set;}
        public string Name
        {
            get { return ProdutName; }
            set { ProdutName = value; }
        }
        public double Price
        {
            get { return ProdutPrice; }
            set { ProdutPrice = value; }
        }
        public int Quantity
        {
            get { return ProdutQuantity; }
            set { ProdutQuantity = value; }
        }

        
        
        public string Type
        {
            get { return ProdutType; }
            set { ProdutType = value; }
        }
        public override string ToString()
        {
            return "ProductName:-" + Name + " " +"ProductPrice:-"+ Price+" "+"ProdctQuantity:-"+Quantity+" "+"ProductType:-"+Type;
        }
       static List<Product> newlist = new List<Product>();


        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>() {
                 new Product(){ Name="lettuce", Price=10.5 ,Quantity=50,Type="Leafy green"},
                 new Product(){ Name="cabbage", Price=20 ,Quantity=100,Type="Cruciferous"},
                 new Product(){ Name="pumpkin", Price=30,Quantity=30,Type="Marrow"},
                 new Product(){ Name="cauliflower", Price=10 ,Quantity=25,Type="Cruciferous"},
                 new Product(){ Name="zucchini", Price=20.5,Quantity=50,Type="Marrow"},
                 new Product(){ Name="yam", Price=30,Quantity=50,Type="Root"},
                 new Product(){ Name="spinach", Price=10 ,Quantity=100,Type="Leafy green"},
                 new Product(){ Name="broccoli", Price=20.2,Quantity=75,Type="Cruciferous"},
                 new Product(){ Name="Garlic", Price=30 ,Quantity=20,Type="Leafy green"},
                 new Product(){ Name="silverbeet", Price=10 ,Quantity=50,Type="Marrow"},
             };
             Console.WriteLine("total number of Product in Product List: ",productList.Count());
            Console.WriteLine("After Adding Product");
            newlist.Add(new Product() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" } );
            Console.WriteLine("total number of Product in Product List: ", newlist.Count());

            foreach (var item in productList)
                Console.WriteLine(item);
            foreach (var item in productList)
            {
                if (item.Type.Equals("Leafy green"))
                    Console.WriteLine(item);
            }

            var itemToRemove = productList.Single(r => r.Name == "Garlic");
            productList.Remove(itemToRemove);
            Console.WriteLine("total number of Product in Product List: ", productList.Count());

            foreach (var item in productList)
            {
                if (item.Name.Equals("cabbage"))
                {
                    int a = item.Quantity + 50 ;
                    item.Quantity = a;
                    Console.WriteLine(item);
                }        
            }
            double total = 0;
            foreach (var item in productList)
            {
                if (item.Name.Equals("lettuce"))
                {
                    total = total + (1) * item.Price;
                }
                if (item.Name.Equals("zucchini,"))
                {
                    total = total + (2) * item.Price;
                }
                if (item.Name.Equals("broccoli"))
                {
                    total = total + (1) * item.Price;
                }
            }
            Console.WriteLine("Rounded Value: ",total);
        }
    }
}