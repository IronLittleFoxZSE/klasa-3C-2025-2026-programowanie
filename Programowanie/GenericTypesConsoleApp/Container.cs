namespace GenericTypesConsoleApp;

class Container<T>
{
    private T item;

    public T Item
    {
        get => item;
        set => item = value;
    }

    public Container(T item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechopwywana: {Item}");
    }
}

class ContainerInt
{
    private int item;

    public int Item
    {
        get => item;
        set => item = value;
    }

    public ContainerInt(int item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechopwywana: {Item}");
    }
}

class ContainerString
{
    private string item;

    public string Item
    {
        get => item;
        set => item = value;
    }

    public ContainerString(string item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine($"Wartość przechopwywana: {Item}");
    }
}
