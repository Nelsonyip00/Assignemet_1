using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    public Transform PlayerTransform;

    private Vector3 _cameraOffest;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffest = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + _cameraOffest;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
