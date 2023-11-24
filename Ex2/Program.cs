using System;

class Program
{
    static void Main()
    {
        Backpack myBackpack = new Backpack("Blue", "ExampleBrand", "ExampleManufacturer", "Nylon", 1.5, 20);

        myBackpack.ItemAdded += (sender, e) =>
        {
            Console.WriteLine($"Added to backpack: {e.ItemName}, Volume: {e.ItemVolume} l");
        };

        try
        {

            myBackpack.AddItem("Book", 2);
            myBackpack.AddItem("Water Bottle", 0.5);
            myBackpack.AddItem("Laptop", 5);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

class Backpack
{
    private string color;
    private string brand;
    private string manufacturer;
    private string material;
    private double weight;
    private double volume;
    private double usedVolume;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public double Volume
    {
        get { return volume; }
        set { volume = value; }
    }

    public double UsedVolume
    {
        get { return usedVolume; }
        private set { usedVolume = value; }
    }

    public event EventHandler<ItemAddedEventArgs> ItemAdded;

    public Backpack(string color, string brand, string manufacturer, string material, double weight, double volume)
    {
        Color = color;
        Brand = brand;
        Manufacturer = manufacturer;
        Material = material;
        Weight = weight;
        Volume = volume;
        UsedVolume = 0;
    }

    public void AddItem(string itemName, double itemVolume)
    {
        if (UsedVolume + itemVolume > Volume)
        {
            throw new InvalidOperationException("Backpack capacity exceeded");
        }

        UsedVolume += itemVolume;

        OnItemAdded(itemName, itemVolume);
    }

    protected virtual void OnItemAdded(string itemName, double itemVolume)
    {
        ItemAdded?.Invoke(this, new ItemAddedEventArgs(itemName, itemVolume));
    }
}

class ItemAddedEventArgs : EventArgs
{
    public string ItemName { get; }
    public double ItemVolume { get; }

    public ItemAddedEventArgs(string itemName, double itemVolume)
    {
        ItemName = itemName;
        ItemVolume = itemVolume;
    }
}

