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
            player.rb.AddForce(Vector3.up * 8f, ForceMode.Impulse);
            player.rb.useGravity = true;
            canClimb = false;
        }
    }
//need player to not be able to climb and jump to go higher than it should be able to

    private void OnTriggerEnter(Collider collision)
    {
        player.rb.velocity = Vector3.zero;
        player.rb.useGravity = false;
        canClimb = true;
        if(collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        player.rb.useGravity = true;
        canClimb = false;
    }
}
