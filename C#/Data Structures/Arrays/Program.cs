using Arrays.Entity;

var shoppingList = new ShoppingList();

Console.WriteLine("=== Adicionando itens à Lista de Compras ===");
shoppingList.ItemAdd("tennis", 1);
shoppingList.ItemAdd("ball", 2);
shoppingList.ItemAdd("", 3);

var response = shoppingList.ToString();
Console.WriteLine("Itens na lista: ");
Console.WriteLine(response + "\n");
Console.WriteLine(new string('-', 30));

Console.WriteLine("=== Adicionando item no meio da Lista de Compras ===");
shoppingList.ItemAdd_WithPosition("socks", 4, 0);
response = shoppingList.ToString();
Console.WriteLine("Itens na lista: ");
Console.WriteLine(response + "\n");
Console.WriteLine(new string('-', 30));

Console.WriteLine("=== Removendo item da Lista de Compras ===");
shoppingList.ItemRemove("socks");
response = shoppingList.ToString();
Console.WriteLine("Itens na lista: ");
Console.WriteLine(response + "\n");
Console.WriteLine(new string('-', 30));



Console.ReadKey();
