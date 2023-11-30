using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class InteractionSystem : MonoBehaviour
{
    [Header("Detection Fields")]
    public Transform detectionPoint;    // Detection point
    private const float detectionRadius = 0.5f; // Detection radius
    public LayerMask detectionLayer;    // Detection layer
    public GameObject detectedObject; // Cached trigger object

    [Header("Examine Fields")]
    public GameObject examineWindow;
    public UnityEngine.UI.Image examineImage;
    public Text examineText;

    [Header("Others")]
    public List<GameObject> pickedItems = new List<GameObject>();// List of picked up items

    void Update()
    {
        if(DetectObject() && IntereactInput())
        {
            detectedObject.GetComponent<Item>().Intereact();
        }
    }

    bool IntereactInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        Collider2D obj = Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);
        if(obj==null)
        {
            detectedObject = null;
            return false;
        }
        else
        {
            detectedObject = obj.gameObject;
            return true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }

    public void PickUpItem(GameObject Item)
    {
        pickedItems.Append(Item);
    }

    public void ExamineItem(Item item)
    {
        examineImage.sprite = item.GetComponent<SpriteRenderer>().sprite;
        examineText.text = item.descriptionText;
        examineWindow.SetActive(true);
    }
}
