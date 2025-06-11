using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private Button mainMenuButton;

    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private int slotCount = 40;

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        mainMenuButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }

    public void SetCharacter(Character character)
    {
        nameText.text = $"{character.Name}";
        levelText.text = $"{character.Level}";
        goldText.text = $"{character.Gold}";
    }

    public void InitInventoryUI()
    {
        var player = GameManager.Instance.Player;

        for (int i = 0; i < slotCount; i++)
        {
            GameObject go = Instantiate(slotPrefab, slotParent);
            UISlot slot = go.GetComponent<UISlot>();
            slots.Add(slot);

            ItemData item = null;
            if (player.Inventory.Count > i)
            {
                item = player.Inventory[i];
            }

            slot.SetItem(item, player);
        }
    }

    public void RefreshInventoryUI()
    {
        var player = GameManager.Instance.Player;

        for (int i = 0; i < slots.Count; i++)
        {
            if (i < GameManager.Instance.Player.Inventory.Count)
            {
                slots[i].SetItem(player.Inventory[i], player);
            }
            else
            {
                slots[i].SetItem(null,player);
            }

            slots[i].gameObject.SetActive(true);
        }
    }
}

