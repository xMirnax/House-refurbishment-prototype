using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRPieInputReader : MonoBehaviour
{

    public InputActionProperty closeMenu;
    public InputActionProperty select;
    public InputActionProperty thumbstickPosition;

    public bool onCloseTrue;
    public bool onSelectTrue;
    public Vector2 thumbstickValue;

    private void Update()
    {
        onCloseTrue = closeMenu.action.ReadValue<float>() > 0.5f;
        onSelectTrue = select.action.ReadValue<float>() > 0.5f;
        thumbstickValue = thumbstickPosition.action.ReadValue<Vector2>();
        thumbstickValue.x *= -1;
    }
}
