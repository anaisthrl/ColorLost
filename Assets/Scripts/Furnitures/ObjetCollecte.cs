using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetCollecte : ObjetARamasser
{
    public static bool hasKey = false;
    AudioSource bonusSound;

    private void Start()
    {
        bonusSound = GameObject.Find("bonusSound").GetComponent<AudioSource>();
    }

    public override void ActionObjetRamasse()
    {
        base.ActionObjetRamasse();
        hasKey = true;
        bonusSound.Play();
    }

    


}

