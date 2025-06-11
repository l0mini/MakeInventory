using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI equippedMark;
    [SerializeField] private Button equipButton;

    private ItemData itemData;
    private Character player;

    public void SetItem(ItemData data, Character character)
    {
        itemData = data;
        player = character;

        if (itemData != null)
        {
            icon.sprite = itemData.Icon;
            icon.enabled = true;
            equippedMark?.gameObject.SetActive(GameManager.Instance.Player.IsEquipped(itemData));
            Debug.Log($"�¾�����{GameManager.Instance.Player.IsEquipped(itemData)}");
        }
        else
        {
            icon.enabled = false;
            equippedMark.gameObject.SetActive(false);
        }
        RefreshUI();
    }

    public void OnClick()
    {

        var player = GameManager.Instance.Player;

        if (player.IsEquipped(itemData))
            player.UnEquip(itemData);
        else
            player.Equip(itemData);
        Debug.Log($"��Ŭ��{player.IsEquipped(itemData)}");

        // ��ü �κ��丮 UI ���ΰ�ħ
        UIManager.Instance.UIInventory.RefreshInventoryUI();

        // ����â�� ���ΰ�ħ
        UIManager.Instance.UIStatus.SetCharacter(player);
    }

    private void RefreshUI()
    {
        if (itemData == null) return;

        bool equipped = player.IsEquipped(itemData);
        equippedMark.gameObject.SetActive(equipped);
    }
}
