using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVertical : MonoBehaviour
{
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, -30, 30);
        transform.localRotation = Quaternion.Euler(rotation,0,0);
        //transform.Rotate(Vector3.left * mouseY);
    }
}
