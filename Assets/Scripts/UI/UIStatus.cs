using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;

    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI criticalText;

    [SerializeField] private Button mainMenuButton;
    private void Start()
    {
        mainMenuButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu); // 버튼에 메소드 연결
    }

    public void SetCharacter(Character character) // 캐릭터 정보 UI 세팅
    {
        nameText.text = $"{character.Name}";
        levelText.text = $"{character.Level}";
        goldText.text = $"{character.Gold}";
        attackText.text = $"{character.TotalAttack}";
        defenseText.text = $"{character.TotalDefense}";
        healthText.text = $"{character.TotalHealth}";
        criticalText.text = $"{character.TotalCritical}";
    }
}
