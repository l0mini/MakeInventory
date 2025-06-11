using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button InventoryButton;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);       // ��ư�� �޼ҵ� ����
        InventoryButton.onClick.AddListener(OpenInventory); // ��ư�� �޼ҵ� ����
    }
    public void OpenStatus() // ����â ���� ��ư
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory() // �κ�â ���� ��ư
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false) ;
        UIManager.Instance.UIInventory.gameObject.SetActive(true) ;
    }

    public void OpenMainMenu() // ���θ޴� ���� ��ư
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }

    public void SetCharacter(Character character) // ĳ���� ���� UI
    {
        nameText.text = $"{character.Name}";
        levelText.text = $"{character.Level}";
        goldText.text = $"{character.Gold}";
    }
}
