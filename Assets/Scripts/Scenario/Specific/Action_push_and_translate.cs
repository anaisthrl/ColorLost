using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_push_and_translate : Action_Scenario_Etape
{
    public GameObject m_gameO;
    Animation anim;
    static public bool cageDown = false;
    public AudioSource cageTranslate;

    override public void Start()
    {
        base.Start();
        anim = m_gameO.GetComponent<Animation>();
    }
    override public void Update()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.transform.gameObject == this.gameObject)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    playAnim();
                }
            }
        }
    }

    void playAnim()
    {
        if (ObjetCollecte.hasKey && m_gameO.CompareTag("cage"))
        {
            anim.Play();
            cageTranslate.Play();
        }

        if (AfficherTextePanel.openDoor && m_gameO.CompareTag("door")|| _MGR_ScenarioManager.p_num_etapeEnCours == 3 || _MGR_ScenarioManager.p_num_etapeEnCours == 4)
        {
            anim.Play();
            Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
