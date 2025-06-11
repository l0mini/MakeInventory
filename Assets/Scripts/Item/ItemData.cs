using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Weapon,
    Armor
}


public class ItemData
{
    public Sprite Icon { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }
    public ItemType Type { get; private set; }

    public ItemData(Sprite icon, int attack, int defense, int health, int critical, ItemType type)
    {
        Icon = icon;
        Attack = attack;
        Defense = defense;
        Health = health;
        Critical = critical;
        Type = type;
    }
}
