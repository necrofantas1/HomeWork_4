namespace HomeWork4;

public class Warehouse
{
    private string[] _items = new string[10];

    public string this[int index]
    {
        get { return _items[index]; }
        set
        {
            _items[index] = value;
            OnItemChanged?.Invoke(index, value);
        }
    }

    public event Action<int, string> OnItemChanged;
    
}

    
        