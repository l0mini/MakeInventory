using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }

    public List<ItemData> Inventory { get; private set; }

    public Character(string name, int level, int gold, int attack, int defense, int health, int critical, List<ItemData> inventory)
    {
        Name = name;
        Level = level;
        Gold = gold;
        Attack = attack;
        Defense = defense;
        Health = health;
        Critical = critical;
        Inventory = inventory;
    }

    public void Additem(ItemData item)
    {
        Inventory.Add(item);
    }

    public void Equip()
    {

    }

    public void UnEquip()
    {

    }
}
