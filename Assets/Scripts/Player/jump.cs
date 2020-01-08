using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody playerRB;
    bool canJump;
    Vector3 jumpVect;
    public float jumpForce;
    void Start()
    {
        playerRB = this.transform.parent.gameObject.GetComponent<Rigidbody>();
        jumpVect = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {
            if (canJump && Input.GetKeyDown(KeyCode.Space))
            {
                playerRB.AddForce(jumpVect * jumpForce, ForceMode.Impulse);
            }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground")
        {
            canJump = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            canJump = false;
        }
    }
}
