using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSound : MonoBehaviour
{
    public AudioSource gameS;//son de fond du jeu

    // Update is called once per frame
    void Update()
    {
        //le son accélèrera au fur et à mesure que le temps arrivera à son terme.
        
        if(_MGR_TimeLine.Instance.chrono >= _MGR_TimeLine.Instance.chrono / 2)
        {
            gameS.pitch = 1.3f;
        }
        if (_MGR_TimeLine.Instance.chrono >= _MGR_TimeLine.Instance.dureeMax-60)
        {
            gameS.pitch = 1.7f;
        }
    }
}
