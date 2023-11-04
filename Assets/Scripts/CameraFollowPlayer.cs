using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position;// + offset;
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, target.position, smoothFactor*Time.fixedDeltaTime);
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }

}
