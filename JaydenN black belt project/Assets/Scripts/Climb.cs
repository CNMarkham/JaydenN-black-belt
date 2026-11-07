using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{

    public bool canClimb;
    public PlayerMove player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canClimb ==  true)
        {
            player.rb.AddForce(Vector3.up * 4f, ForceMode.Impulse);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        canClimb = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        canClimb = false;
    }
}
