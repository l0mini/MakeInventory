using UnityEngine;
using UnityEngine.UI;


public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;

    private ItemData itemData;

    public void SetItem(ItemData data)
    {
        itemData = data;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (itemData != null)
        {
            icon.sprite = itemData.Icon;
            icon.enabled = true;
        }
        else
        {
            icon.enabled = false;
        }
    }
}
