using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class CombatSystem : MonoBehaviour
{
    [Header("Detection Fields")]
    public Transform detectionPoint;    // Detection point
    private const float detectionRadius = 2f; // Detection radius
    public LayerMask detectionLayer;    // Detection layer
    public GameObject detectedObject; // Cached trigger object

    void Update()
    {
        if(DetectObject() && IntereactInput())
        {
            detectedObject.GetComponent<EnemyAI>().Hurt();
        }
    }

    bool IntereactInput()
    {
        return Input.GetMouseButtonDown(0);
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
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }
}