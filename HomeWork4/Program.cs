namespace HomeWork4;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Warehouse warehouse = new Warehouse();
        
        warehouse.OnItemChanged += (index, item) => Console.WriteLine($"У комірку №{index} додано товар {item}");
        
        List<string> items = new List<string> { "пляшка", "телефон", "PC" , "шкатулка" , "книга", "", "лампа", "", "", "годинник" };
        
        
        Predicate<string> isValidName = name => !string.IsNullOrWhiteSpace(name);
        
        Func<string , string> itemNameToUpper = name => name.ToUpper();

        int addIndex = 0;
        
        foreach (string item in items)
        {
            if (isValidName(item))
            {
                warehouse[addIndex] = itemNameToUpper(item);
                addIndex++;
            }
        }

        for (int i = 0; i < addIndex; i++)
        {
            Console.WriteLine($"Комірка №{i}: {warehouse[i]}");
        }
        Console.ReadKey();
    }
}