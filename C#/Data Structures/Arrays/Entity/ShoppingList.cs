using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Entity;
public class ShoppingList
{
    Product[] Products { get; set; } = new Product[0];

    public override string ToString()
    {
        return string.Join(", ", Products.Select(p => p.ToString()));
    }

    public void ItemRemove(string name)
    {
        int index = -1;
        for (int i = 0; i < Products.Length; i++)
        {
            if (Products[i].Name == name)
            {
                index = i;
                break;
            }
        }
        if (index == -1)
            return;

        Product[] newProducts = new Product[Products.Length - 1];

        for (int i = 0, j = 0; i < Products.Length; i++)
        {
            if (i == index) continue;
            newProducts[j++] = Products[i];
        }

        Products = newProducts;
    }

    public void ItemAdd(string name, int quantity)
    {
        try
        {
            Product product = new Product(quantity, name);
            Product[] newProducts = new Product[Products.Length + 1];

            for (int i = 0; i < Products.Length; i++)
            {
                newProducts[i] = Products[i];
            }

            newProducts[Products.Length] = product;
            Products = newProducts;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"{ex.Source} : {ex.Message} ,\n {ex.StackTrace}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Source} : {ex.Message} ,\n {ex.StackTrace}");
            throw;
        }

        
    }

    public void ItemAdd_WithPosition(string name, int quantity, int pos)
    {
        try
        {
            Product product = new Product(quantity, name);
            Product[] newProducts = new Product[Products.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                newProducts[i] = Products[i];
            }

            newProducts[pos] = product;
            for (int i = pos; i < Products.Length; i++)
            {
                newProducts[i + 1] = Products[i];
            }

            Products = newProducts;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"{ex.Source} : {ex.Message} ,\n {ex.StackTrace}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Source} : {ex.Message} ,\n {ex.StackTrace}");
            throw;
        }
    }
}
