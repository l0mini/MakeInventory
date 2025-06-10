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
            new ItemData(swordIcon),
        };
        Player = new Character("Chad", 5, 5000, 10, 15, 100, 20, items);
        UIManager.Instance.UIMainMenu.SetCharacter(Player);
        UIManager.Instance.UIStatus.SetCharacter(Player);
        UIManager.Instance.UIInventory.SetCharacter(Player);
        uiInventory.InitInventoryUI();
    }
}
