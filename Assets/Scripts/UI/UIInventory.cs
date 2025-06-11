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
    [SerializeField] private int slotCount = 40; // 슬롯 생성 갯수

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        mainMenuButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu); // 버튼에 메소드 연결
    }

    public void SetCharacter(Character character) // 캐릭터 정보 UI 세팅
    {
        nameText.text = $"{character.Name}";
        levelText.text = $"{character.Level}";
        goldText.text = $"{character.Gold}";
    }

    public void InitInventoryUI() // 시작시 빈슬롯 생성 및 인벤토리 리스트 내 아이템 세팅
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

    public void RefreshInventoryUI() // 아이템 장착 & 해제시 UI 다시 세팅
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

