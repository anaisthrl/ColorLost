using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageRecup : MonoBehaviour
{

    public Sprite sprite_image;//image à mettre quand l'objet est ramassé

    public Image m_image;//sprite d'origine
    public Sprite sprite_vide;//image d'inventaire vide

    bool isRecup = false;


    private void Start()
    {
       m_image.sprite = sprite_vide;
    }
    // Update is called once per frame
    void Update()
    {
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 0) {
            isRecup = AfficherTextePanel.isRecup1;
            if (isRecup){m_image.sprite = sprite_image;}
        }
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 1) {
            isRecup = AfficherTextePanel.isRecup2;
            if (isRecup) { m_image.sprite = sprite_image; }
        }
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 2) {
            isRecup = AfficherTextePanel.isRecup3;
            if (isRecup) { m_image.sprite = sprite_image; }
        }
    
    }
}
