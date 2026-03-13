using System;
using System.Collections.Generic;
using System.Text;

class InventoryFullException : Exception
{
    public int Capacity { get; }
    public string ItemName { get; }

    public InventoryFullException(int capacity, string itemName)
        : base($"[인벤토리 오류] 인벤토리가 가득 찼습니다.(용량: {capacity}, 아이템: {itemName})")
    {
        Capacity = capacity;
        ItemName = itemName;
    }
}

class ItemNotFoundException : Exception
{
    public string ItemName { get; }

    public ItemNotFoundException(string itemName)
        : base($"[인벤토리 오류] 아이템을 찾을 수 없습니다: {itemName}")
    {
        ItemName = itemName;
    }
}
