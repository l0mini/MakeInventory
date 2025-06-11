using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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

    // 같은 타입의 장비를 장칙시 자동으로 해제 될 수 있게 딕셔너리 사용
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

    public void Equip(ItemData item) // 장착
    {
        EquippedItems[item.Type] = item;
        Debug.Log($"이큅{EquippedItems.Count}");
    }

    public void UnEquip(ItemData item) // 해제
    {
        if (EquippedItems.ContainsKey(item.Type) && EquippedItems[item.Type] == item) // 키값 비교
        {
            EquippedItems.Remove(item.Type);
        }
        Debug.Log($"언이큅{item.Type}");
    }

    public bool IsEquipped(ItemData item)
    {
        if (item == null || EquippedItems == null) return false;
        return EquippedItems.ContainsKey(item.Type) && EquippedItems[item.Type] == item;
    }
}
