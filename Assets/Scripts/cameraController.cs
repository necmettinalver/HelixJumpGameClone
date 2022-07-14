using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float betweenSpeed;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, offset+ball.position, betweenSpeed);
        transform.position = newPosition;
          
    }
}
