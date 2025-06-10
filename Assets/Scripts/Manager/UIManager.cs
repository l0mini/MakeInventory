using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIInventory uiInventory;
    [SerializeField] private UIStatus uiStatus;

    public UIMainMenu UIMainMenu { get { return uiMainMenu; } }
    public UIInventory UIInventory { get { return uiInventory; } }
    public UIStatus UIStatus { get { return uiStatus; } }

    public static UIManager Instance { get; private set; }

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
