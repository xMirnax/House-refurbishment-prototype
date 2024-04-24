using SimplePieMenu;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectedItem : MonoBehaviour, IMenuItemClickHandler
{
    [SerializeField] private XRBaseInteractor interactor;
    public XRInteractionManager interactionManager;
    public XRGrabInteractable grabInteractable;
    
    public void Handle()
    {
        interactionManager.ForceSelect(interactor, grabInteractable);
    }
}
