using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void Replay()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("Scene_Play");
    }
}
