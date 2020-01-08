using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObjects : MonoBehaviour
{
    public float maxDistance;
    Material baseMaterial;
    public Material highlightMaterial;

    void Start()
    {
        baseMaterial = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            if (hit.transform.gameObject == this.gameObject)
            {
                GetComponent<MeshRenderer>().material = highlightMaterial;
            }
            else GetComponent<MeshRenderer>().material = baseMaterial;
        }
        else GetComponent<MeshRenderer>().material = baseMaterial;
    }
}
