using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactions_canvas : MonoBehaviour
{

    public CanvasGroup m_canvasGActuel;
    public Canvas m_canvasActuel;

    public float compteRebours;
    public Text textCompteRebours;

    public static bool isInCanvas = false; //on bloque la rotation de la caméra lorsque nous sommes dans un canvas

    private void Update()
    {
        if (m_canvasGActuel.alpha == 0) //si le canvas n'es pas activé
        {
            isInCanvas = false;
            openCanvasWithKeyCode();
        }
        else //si le canvas est activé
        {
            isInCanvas = true;
            Cursor.lockState = CursorLockMode.None;
            quitCanvasWithKeyCode();
        }

        compteRebours -= Time.deltaTime;
        if (textCompteRebours) textCompteRebours.text = "La suite dans " + (int)compteRebours + " secondes...";
    }

    public void openCanvasWithKeyCode()
    {

        if ((Input.GetKeyDown(KeyCode.H)) && (m_canvasActuel.CompareTag("help")))
        {
            m_canvasGActuel.alpha = 1;
            _MGR_TimeLine.Instance.chrono += 120;//lorsqu'on demande un indice on perd deux minutes.
        }

    }

    public void quitCanvasWithKeyCode()
    {

        if ((Input.GetKeyDown(KeyCode.H)) && (m_canvasGActuel.CompareTag("help")))
            m_canvasGActuel.alpha = 0;
        if (m_canvasActuel.CompareTag("openSceneCanvas")) { Invoke("DestroyDelay", 10); }
    }

    void DestroyDelay()
    {
        Destroy(m_canvasActuel.gameObject);
    }
}