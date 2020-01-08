using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgessBar_TL : MonoBehaviour
{
    public Slider progressBarTimeLeft;

    // Start is called before the first frame update
    void Start()
    {
        progressBarTimeLeft.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float chrono = _MGR_TimeLine.Instance.chrono;
        progressBarTimeLeft.value = _MGR_TimeLine.Instance.chrono / _MGR_TimeLine.DURE_MAX_PAR_DEFAUT;
    }
}
