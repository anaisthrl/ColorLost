using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class index : MonoBehaviour
{
    public Text m_texte_indice;
    public CanvasGroup m_canvasOpenG;
    public CanvasGroup m_canvasG;

    // Update is called once per frame
    void Update()
    {
            m_texte_indice.text = "Pas encore d'indice disponible mais les indices de la pièce finale sont cachés dans le decort.";
            changeText();
            
    }

    private void changeText()
    {
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 0 && Action_push_and_translate.cageDown) { m_texte_indice.text = "Vous ne seriez pas mieux assis quelque part ?"; }
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 1 ) { m_texte_indice.text = "Nous sommes en informatique non ?"; }
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 2 ) { m_texte_indice.text = "Ces bustes ont besoin d'un nettoyage."; }
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 3 ) { m_texte_indice.text = "Servez vous de vos oreilles..."; }
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 4) { m_texte_indice.text = "Les multiplications et divisions sont prioritaires."; }
    }


}
