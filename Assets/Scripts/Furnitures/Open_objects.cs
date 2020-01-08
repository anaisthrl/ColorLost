using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_objects : MonoBehaviour
{
    GameObject player;
    public GameObject objectAOuvrir;
    private bool isOpen = false;
    public Transform tranf;
    float distance;
    public float maxDistance;
    bool chronoIsStarted = false;
    float chrono = 0;
    public float maxChrono;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);

        if (isOpen == true && objectAOuvrir.CompareTag("banc") && objectAOuvrir.layer == 9)
        {
            if (!chronoIsStarted) chronoIsStarted = true;
            else
            {
                chrono += Time.deltaTime;
                transform.parent.Rotate(new Vector3(-0.2f, 0, 0));
            }
            if (chrono >= 1) chronoIsStarted = false;
            //var newRot = Quaternion.RotateTowards(tranf.rotation, Quaternion.Euler(-180.0f, 0.0f, 0.0f), Time.deltaTime * 250);
            //tranf.rotation = newRot;
        }

        if (isOpen == true && objectAOuvrir.CompareTag("door") && objectAOuvrir.layer == 9)
        {
            var newRot = Quaternion.RotateTowards(tranf.rotation, Quaternion.Euler(-90.0f, 0.0f, 90.0f), Time.deltaTime * 250);
            tranf.rotation = newRot;
        }
    }

    private void OnMouseDown()
    {
        if (distance < maxDistance) isOpen = true;
    }
}
