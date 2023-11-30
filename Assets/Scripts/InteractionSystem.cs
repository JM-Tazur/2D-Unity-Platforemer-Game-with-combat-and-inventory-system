using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    public Transform detectionPoint;
    private const float detectionRadius = 0.5f;
    public LayerMask detectionLayer;

    void Update()
    {
        if(DetectObject() && IntereactInput())
        {
            Debug.Log("INTEARACTION");
        }
    }

    bool IntereactInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        bool isDetected = Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);
        return isDetected;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }
}
