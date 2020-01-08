using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bonus : ObjetARamasser
{
    public Text textScore;
    AudioSource bonusSound;

    void Start()
    {
        bonusSound = GameObject.Find("bonusSound").GetComponent<AudioSource>();
    }

    public override void ActionObjetRamasse()
    {
        base.ActionObjetRamasse();
        _MGR_GamePlay.Instance.AugmenterScore(1);
        textScore.text = " " + _MGR_GamePlay.score;
        if (_MGR_TimeLine.Instance.chrono > 60) _MGR_TimeLine.Instance.chrono -= 60; //lorsqu'on attrape un bonus on gagne une min
        else _MGR_TimeLine.Instance.chrono = 0;
        bonusSound.Play();
    }
}
