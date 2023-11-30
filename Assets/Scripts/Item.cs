using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum InteractionType {NONE, PickUp, Examine}
    public InteractionType type;
    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 6;
    }

    public void Intereact()
    {
        switch(type)
        {
            case InteractionType.PickUp:
                GameObject item = gameObject;
                FindObjectOfType<InteractionSystem>().PickUpItem(item);
                gameObject.SetActive(false);
                break;
            case InteractionType.Examine:
                Debug.Log("Examine");
                break;
            default:
                Debug.Log("NULL");
                break;
        }
    }
}
