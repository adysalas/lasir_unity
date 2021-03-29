using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// camera follow script (https://www.youtube.com/watch?v=MFQhpwc6cKE) 

public class cameraPos : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }



}
