using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private Sprite swordIcon;
    [SerializeField] private Sprite axIcon;
    [SerializeField] private Sprite sheldIcon;
    [SerializeField] private Sprite armorIcon;
    public static GameManager Instance { get; private set; }

    public Character Player {  get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        SetData();
    }

    private void SetData()
    {
        var items = new List<ItemData>
        {
            new ItemData(swordIcon, 10, 5, 0, 20, ItemType.Weapon),
            new ItemData(axIcon, 20, 0, 0, 10, ItemType.Weapon),
            new ItemData(sheldIcon, 0, 15, 100, 0, ItemType.Armor),
            new ItemData(armorIcon, 0, 20, 50, 0, ItemType.Armor),
        };
        Player = new Character("Chad", 5, 5000, items);
        UIManager.Instance.UIMainMenu.SetCharacter(Player);
        UIManager.Instance.UIStatus.SetCharacter(Player);
        UIManager.Instance.UIInventory.SetCharacter(Player);
        uiInventory.InitInventoryUI();
    }
}
