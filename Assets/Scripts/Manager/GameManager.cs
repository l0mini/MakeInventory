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
        var items = new List<ItemData> //아이템 리스트에 아이템 추가
        {
            new ItemData(swordIcon, 10, 5, 0, 20, ItemType.Weapon),
            new ItemData(axIcon, 20, 0, 0, 10, ItemType.Weapon),
            new ItemData(sheldIcon, 0, 15, 100, 0, ItemType.Armor),
            new ItemData(armorIcon, 0, 20, 50, 0, ItemType.Armor),
        };
        Player = new Character("Chad", 5, 5000, items);     // 플레이어 데이터 설정
        UIManager.Instance.UIMainMenu.SetCharacter(Player); // UI 세팅
        UIManager.Instance.UIStatus.SetCharacter(Player);   // UI 세팅
        UIManager.Instance.UIInventory.SetCharacter(Player);// 아이템슬롯 및 UI 세팅
        uiInventory.InitInventoryUI(); // 인벤토리 초기화
    }
}
