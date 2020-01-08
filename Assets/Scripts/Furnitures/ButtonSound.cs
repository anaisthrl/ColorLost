using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    Animation buttonAnimation;
    public float maxDistance;
    public string buttonType;
    AudioSource music;
    AudioSource reversedMusic;
    void Start()
    {
        buttonAnimation = GetComponent<Animation>();
        music = GameObject.Find("music").GetComponent<AudioSource>();
        reversedMusic = GameObject.Find("reversedMusic").GetComponent<AudioSource>();
    }

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            if (hit.transform.gameObject == this.gameObject)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    buttonAnimation.Play();

                    switch (buttonType)
                    {
                        case "play":
                            if (reversedMusic.isPlaying) reversedMusic.Stop();
                            music.Play();
                            break;
                        case "reversed":
                            if (music.isPlaying) music.Stop();
                            reversedMusic.Play();
                            break;
                        case "speeddown":
                            if (music.isPlaying) music.pitch = 0.6f;
                            else if (reversedMusic.isPlaying) reversedMusic.pitch = 0.6f;
                            break;
                        case "speedup":
                            if (music.isPlaying) music.pitch = 1.5f;
                            else if (reversedMusic.isPlaying) reversedMusic.pitch = 1.5f;
                            break;
                        case "stop":
                            if (music.isPlaying) music.Stop();
                            if (reversedMusic.isPlaying) reversedMusic.Stop();
                            music.pitch = 1;
                            reversedMusic.pitch = 1;
                            break;
                    }
                }
            }
        }
    }
}
