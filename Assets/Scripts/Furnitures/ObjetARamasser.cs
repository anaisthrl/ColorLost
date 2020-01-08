using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetARamasser : MonoBehaviour
{
    public virtual void ActionObjetRamasse() { Destroy(gameObject);  }
    public void ActionObjetRamasse(float _delai) { Invoke("ActionObjetRamasse", _delai); }
    private void Update(){ transform.Rotate(90 * Time.deltaTime, 0, 0);}
}
