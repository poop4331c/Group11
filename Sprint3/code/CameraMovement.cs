using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 offSet;
    public float smoothFactor = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        offSet = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + offSet;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }
}
