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
        statusButton.onClick.AddListener(OpenStatus);       // 버튼에 메소드 연결
        InventoryButton.onClick.AddListener(OpenInventory); // 버튼에 메소드 연결
    }
    public void OpenStatus() // 스텟창 오픈 버튼
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory() // 인벤창 오픈 버튼
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false) ;
        UIManager.Instance.UIInventory.gameObject.SetActive(true) ;
    }

    public void OpenMainMenu() // 메인메뉴 오픈 버튼
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }

    public void SetCharacter(Character character) // 캐릭터 정보 UI
    {
        nameText.text = $"{character.Name}";
        levelText.text = $"{character.Level}";
        goldText.text = $"{character.Gold}";
    }
}
