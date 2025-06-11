using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // UIManager를 통해서 작동하도록 연결
    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private UIStatus uiStatus;

    public UIMainMenu UIMainMenu { get { return uiMainMenu; } }
    public UIInventory UIInventory { get { return uiInventory; } }
    public UIStatus UIStatus { get { return uiStatus; } }

    public static UIManager Instance { get; private set; } // UI 매니저 싱글톤

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
}
