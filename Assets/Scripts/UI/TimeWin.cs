using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeWin : MonoBehaviour
{
    Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        m_text.text = "Temps : " + (int)(_MGR_TimeLine.Instance.chrono) + " secondes .";
    }
}
