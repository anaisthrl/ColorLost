using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbedObjectSensor : MonoBehaviour
{
    bool isTouching;
    GameObject grabbedObject;
    public float goingDownSpeed;
    int objectCount;

    void Start()
    {
        isTouching = false;
        objectCount = 0;
    }

    void Update()
    {
        if (isTouching)
        {
            grabbedObject.GetComponent<BoxCollider>().enabled = false;
            grabbedObject.transform.position -= new Vector3(0, goingDownSpeed / 100, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 20)
        {
            isTouching = true;
            grabbedObject = other.gameObject;
            objectCount++;
            Invoke("DestroyGrabbed", 3);
        }
    }

    void DestroyGrabbed()
    {
        isTouching = false;
        Destroy(grabbedObject);
    }
}
