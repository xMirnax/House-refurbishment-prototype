using System;
using System.Collections;
using System.Collections.Generic;
using SimplePieMenu;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPieMenu : MonoBehaviour
{
    [SerializeField] private GameObject pieCanva;
    [SerializeField] private PieMenu pieMenu;
    public InputActionProperty openMenu;

    public bool isInitialized = false;
    private bool menuOpen = false;

    private void Update()
    {
        menuOpen = openMenu.action.ReadValue<float>() > 0.5f;

        if (menuOpen)
        {
            ShowPieMenu();
        }
    }

    public void ShowPieMenu()
    {
        if (isInitialized == false)
        {
            pieCanva.SetActive(true);
            isInitialized = true;
        }
        else
        {
            PieMenuShared.References.PieMenuToggler.SetActive(pieMenu, true);
        }
    }
}
