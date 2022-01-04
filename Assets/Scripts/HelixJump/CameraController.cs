using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Camera cam;
    private Vector3 offset;
    [SerializeField] private float smoothSpeed;
    void Start()
    {
        offset=transform.position-target.position;
    }
    
    void Update()
    {
        Vector3 position=Vector3.Lerp(transform.position,offset+target.position,smoothSpeed);
        transform.position=position;
    }
}
