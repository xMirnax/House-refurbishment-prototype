using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HideLeftHand : MonoBehaviour
{
    public GameObject hand;

    private void Start()
    {
        XRRayInteractor grabInteractable = GetComponent<XRRayInteractor>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    {
        hand.SetActive(false);
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        hand.SetActive(true);
    }
    
}
