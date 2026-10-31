using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVertical : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.left * mouseY);
    }
}
