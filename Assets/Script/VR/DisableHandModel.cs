using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHandModel : MonoBehaviour
{
    public GameObject hand;

    private void Start()
    {
        XRDirectInteractor grabInteractable = GetComponent<XRDirectInteractor>();
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
