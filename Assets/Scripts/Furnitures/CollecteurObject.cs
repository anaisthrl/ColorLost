using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecteurObject : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        //CommonDevTools.DEBUG("objet touché : " + other.name + "objet source" + gameObject.name);
        ObjetARamasser __o = other.gameObject.GetComponent<ObjetARamasser>();
        if (__o == null)
            CommonDevTools.ERROR("erreur sur objet à ramasser ! ", other.gameObject);
        else
            __o.ActionObjetRamasse();
    }
}
