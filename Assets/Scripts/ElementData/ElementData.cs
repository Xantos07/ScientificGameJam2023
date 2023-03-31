using UnityEngine;
using UnityEngine.EventSystems;

public class ElementData : MonoBehaviour, IPointerDownHandler
{
    // Base a revoir 
    [SerializeField] private string name;
    [SerializeField] private int ressource;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Here");
        
        
    }
}
