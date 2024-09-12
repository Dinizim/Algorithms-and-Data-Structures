using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Entity;
public class Product
{
    public Product(int quantity, string name)
    {
        if(quantity == 0)
        {
            throw new ArgumentException("Quantity must be greater than 0");
        }
        Quantity = quantity;
        if (String.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Name is not empty");
        }
        Name = name;
    }

    public int Quantity { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{Name} (Quantity: {Quantity})";
    }
}
