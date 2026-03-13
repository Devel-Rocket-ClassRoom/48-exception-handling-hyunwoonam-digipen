using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

Inventory inventory = new Inventory(3);

Console.WriteLine("=== 인벤토리 테스트 ===");

try
{
    inventory.AddItem("검");
    inventory.AddItem("방패");
    inventory.AddItem("포션");
    inventory.AddItem("활");
}
catch (InventoryFullException ex)
{
    Console.WriteLine($"{ex.Message}");
}

Console.WriteLine();

inventory.ShowItems();

try
{
    inventory.RemoveItem("포션");
    inventory.RemoveItem("도끼");
}
catch (ItemNotFoundException ex)
{
    Console.WriteLine($"{ex.Message}");
}

Console.WriteLine();

inventory.ShowItems();