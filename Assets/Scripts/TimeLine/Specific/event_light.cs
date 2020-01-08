using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class event_light : MonoBehaviour, Interface_TL_Events
{
    public GameObject lightEvent;
    public Material baseMaterial;
    public Material lightMaterial;
    private float DebutEventTL = 10;
    public bool Periodique = true;
    public float Periode = 3;
    public float DureeEventTL = 3;
    public float MaxDureeEventTL = 3;

    public void Awake()
    {
    }


    public void stop_TL_Event()
    {
        lightEvent.gameObject.SetActive(true);
        print("ON");
    }

    public float getDuration_TL_Event()
    {
        return DureeEventTL;
    }

    public float getStartTime_TL_Event()
    {
        return DebutEventTL;
    }
    public float getStopTime_TL_Event()
    {
        return DebutEventTL + MaxDureeEventTL;
    }


    public bool isPausable_TL_Event()
    {
        return false;
    }
    public bool isPerdiodic_TL_Event(out float period)
    {
        period = Periode;
        return Periodique;
    }

    public bool isRandomizable_TL_Event()
    {
        return false;// rien à faire ou pas prévu
    }

    public void pause_TL_Event()
    {
        return;
    }
    public void unpause_TL_Event()
    {
        return;
    }
    public void randomize_TL_Event()
    {
        return; // rien à faire ou pas prévu
    }

    public void restart_TL_Event()
    {
        lightEvent.gameObject.SetActive(false);
        print("OFF");
    }


    public void start_TL_Event()
    {
        lightEvent.gameObject.SetActive(false);
        print("OFF");
    }

    public void TL_ChronoArrete()
    {
        return; // rien à faire ou pas prévu
    }

    public void TL_ChronoDemarre()
    {
        return; // rien à faire ou pas prévu
    }

    public void TL_ChronoEnPause()
    {
        return; // rien à faire ou pas prévu
    }
    public void TL_ChronoReprise()
    {
        return; // rien à faire ou pas prévu
    }
}
