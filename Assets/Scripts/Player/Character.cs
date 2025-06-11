using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }
    public int BaseAttack = 10;
    public int BaseDefense = 15;
    public int BaseHealth = 100;
    public int BaseCritical = 15;
    public List<ItemData> Inventory { get; private set; } = new List<ItemData>();
    public Dictionary<ItemType, ItemData> EquippedItems { get; private set; } = new Dictionary<ItemType, ItemData>();

    public int TotalAttack => BaseAttack + EquippedItems.Values.Sum(item => item.Attack);
    public int TotalDefense => BaseDefense + EquippedItems.Values.Sum(item => item.Defense);
    public int TotalHealth => BaseHealth + EquippedItems.Values.Sum(item => item.Health);
    public int TotalCritical => BaseCritical + EquippedItems.Values.Sum(item => item.Critical);

    public Character()
    {
        Inventory = new List<ItemData>();
        EquippedItems = new Dictionary<ItemType, ItemData>();
    }
    public Character(string name, int level, int gold, List<ItemData> inventory)
    {
        Name = name;
        Level = level;
        Gold = gold;
        Inventory = inventory;
    }

    public void Equip(ItemData item)
    {
        EquippedItems[item.Type] = item;
        Debug.Log($"ภฬลข{EquippedItems.Count}");
    }

    public void UnEquip(ItemData item)
    {
        if (EquippedItems.ContainsKey(item.Type) && EquippedItems[item.Type] == item)
        {
            EquippedItems.Remove(item.Type);
        }
        Debug.Log($"พ๐ภฬลข{item.Type}");
    }

    public bool IsEquipped(ItemData item)
    {
        if (item == null || EquippedItems == null) return false;
        return EquippedItems.ContainsKey(item.Type) && EquippedItems[item.Type] == item;
    }
}
