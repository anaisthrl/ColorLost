using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_bustes : Action_Scenario_Etape
{
    int nbBustes;
    public GameObject buste1, buste2, buste3, buste4;
    bool isThrowable1, isThrowable2, isThrowable3, isThrowable4;

    public override void Start()
    {
        base.Start();
        nbBustes = 0;
        isThrowable1 = true;
        isThrowable2 = true;
        isThrowable3 = true;
        isThrowable4 = true;
    }
    public override void Update()
    {
        Debug.Log(nbBustes);
        if (nbBustes == 4) Declencher_Etape_Suivante_Du_Scenario();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == buste1.gameObject && isThrowable1)
        {
            nbBustes++;
            isThrowable1 = false;
        }
        else if (other.gameObject == buste2.gameObject && isThrowable2)
        {
            nbBustes++;
            isThrowable2 = false;
        }
        else if (other.gameObject == buste3.gameObject && isThrowable3)
        {
            nbBustes++;
            isThrowable3 = false;
        }
        else if (other.gameObject == buste4.gameObject && isThrowable4)
        {
            nbBustes++;
            isThrowable4 = false;
        }
    }
}
