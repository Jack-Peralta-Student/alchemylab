using UnityEngine;
using UnityEngine.Events;
public class InteractionsObjects : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an Interactiable object!!";

    public UnityEvent OnInteract = new UnityEvent();

    private void OnEnable()
    {
    
    }
    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        OnInteract.Invoke();
    }
}
