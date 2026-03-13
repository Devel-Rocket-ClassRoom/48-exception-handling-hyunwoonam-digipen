using System;
using System.Collections.Generic;
using System.Text;

class Inventory
{
    private int maxCapacity;
    private List<string> items;

    public Inventory(int maxCapacity)
    {
        this.maxCapacity = maxCapacity;

        items = new List<string>();
    }

    public void AddItem(string itemName)
    {
        if (items.Count >= maxCapacity)
        {
            throw new InventoryFullException(maxCapacity, itemName);
        }

        items.Add(itemName);

        Console.WriteLine($"아이템 '{itemName}' 추가됨");
    }

    public void RemoveItem(string itemName)
    {
        if (items.Contains(itemName) == false)
        {
            throw new ItemNotFoundException(itemName);
        }

        items.Remove(itemName);

        Console.WriteLine($"아이템 '{itemName}' 제거됨");
    }

    public void ShowItems()
    {
        Console.WriteLine($"현재 인벤토리: {string.Join(", ", items)}");
    }
}
