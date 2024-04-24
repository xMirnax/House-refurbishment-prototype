using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePieMenu;
using Unity.VisualScripting;
using UnityEngine.InputSystem;

public class VRControllerPieMenuInput : MonoBehaviour, IInputDevice
{
    private VRPieInputReader input;

    private void Start()
    {
        input = FindAnyObjectByType<VRPieInputReader>();
    }

    public Vector2 GetPosition(Vector2 anchoredPosition)
    {
        return input.thumbstickValue;
    }

    public bool IsSelectionButtonPressed()
    {
        return input.onSelectTrue;
    }

    public bool IsCloseButtonPressed()
    {
        return input.onCloseTrue;
    }
}
