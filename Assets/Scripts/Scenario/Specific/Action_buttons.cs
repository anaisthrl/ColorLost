using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_buttons : Action_Scenario_Etape
{
    public GameObject button1, button2, button3, button4;
    bool isPushable1, isPushable2, isPushable3, isPushable4;
    int count;
    public float maxDistance;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
        count = 0;
        isPushable1 = true;
        isPushable2 = true;
        isPushable3 = true;
        isPushable4 = true;
    }

    // Update is called once per frame
    override public void Update()
    {
        Debug.Log(count);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            if (hit.transform.gameObject == button1.gameObject && isPushable1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    count++;
                    isPushable1 = false;
                }
            }
            else if(hit.transform.gameObject == button2.gameObject && isPushable2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    count++;
                    isPushable2 = false;
                }
            }
            else if (hit.transform.gameObject == button3.gameObject && isPushable3)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    count++;
                    isPushable3 = false;
                }
            }
            else if (hit.transform.gameObject == button4.gameObject && isPushable4)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    count++;
                    isPushable4 = false;
                }
            }
        }

        if (count == 4) Declencher_Etape_Suivante_Du_Scenario();
    }
}
