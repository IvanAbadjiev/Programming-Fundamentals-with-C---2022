namespace P06._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (command != "end")
            {
                string[] data = command.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQty = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);


                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQty);
                boxes.Add(box);
                command = Console.ReadLine();
            }
            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:F2}");
            }


        }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerBox
        {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }

    public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }

            public decimal Price { get; set; }
        }
    }
