using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePieMenu;

public class DisableMenuItem : MonoBehaviour
{
    [SerializeField] PieMenu pieMenu;
    private void Awake()
    {
        pieMenu.OnPieMenuFullyInitialized += OnDisableMenuItem;
    }
    private void OnDestroy()
    {
        pieMenu.OnPieMenuFullyInitialized -= OnDisableMenuItem;
    }
    private void OnDisableMenuItem()
    {
        int menuItemId = 2;
        bool disabled = true;
        MenuItemDisabler disabler = 
            PieMenuShared.References.MenuItemsManager.MenuItemDisabler;
        disabler.ToggleDisable(pieMenu, menuItemId, disabled);
    }
}
