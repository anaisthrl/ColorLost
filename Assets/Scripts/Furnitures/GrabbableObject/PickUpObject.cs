using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public float throwForce;
    float distance;
    public float maxDistance;
    Vector3 objectPos;

    public bool isHolding;
    GameObject tempParent;

    public Material baseMaterial;
    public Material highlightMaterial;

    void Start()
    {
        isHolding = false;
        tempParent = GameObject.Find("Main Camera");
    }

    void Update()
    {
        distance = Vector3.Distance(transform.position, tempParent.transform.position);

        if (distance >= maxDistance) isHolding = false;

        if (isHolding)
        {
            GetComponent<MeshRenderer>().material = baseMaterial;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }
        }
        else
        {
            objectPos = transform.position;
            transform.SetParent(null);
            GetComponent<Rigidbody>().useGravity = true;
            transform.position = objectPos;
        }

        //raycast highlight

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            if (hit.transform.gameObject == this.gameObject && isHolding == false)
            {
                GetComponent<MeshRenderer>().material = highlightMaterial;
            }
            else GetComponent<MeshRenderer>().material = baseMaterial;
        }
        else GetComponent<MeshRenderer>().material = baseMaterial;
    }

    private void OnMouseDown()
    {
        if (distance <= maxDistance)
        {
            isHolding = true;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().detectCollisions = true;
        }
    }

    private void OnMouseUp()
    {
        isHolding = false;
    }
}
