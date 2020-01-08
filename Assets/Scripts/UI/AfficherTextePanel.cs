using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfficherTextePanel : MonoBehaviour
{
    public GameObject player;
    public Text m_TextAAfficher; 
    public int m_iBookNumber;
    public GameObject m_gameObject;
    public CanvasGroup m_canvasG;
    private bool isOk = false; //a-t-on appuyer sur l'objet?
    float distance;
    public float maxDistance;
    static public bool openDoor = false; //lorsqu'on trouve le papier qui permet d'ouvrir la porte de la salle 1 cette dernière pourra s'ouvrir
    static public bool isRecup1 =false; //lorsque nous avons ramassé le premier papier
    static public bool isRecup2=false; //lorsque nous avons ramassé le deuxieme papier
    static public bool isRecup3=false; //lorsque nous avons ramassé le troisieme papier

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);


        if (m_gameObject.CompareTag("book") && (isOk == true) )
        {//si l'objet est un livre
            m_canvasG.alpha = 1;
            choiseSummary();
        }

        if ((m_gameObject.CompareTag("paper") || m_gameObject.CompareTag("paperIndiceFinal")) && (isOk ==true))
        { //si l'objet est un morceau de papier
            m_canvasG.alpha = 1;
            choisePaperTexte();
        }

        if ((m_gameObject.CompareTag("paint") && (isOk==true)))
        {//si l'objet est une painture
            m_TextAAfficher.text = "Vous venez de\n trouver un petit bout\n de papier glissé dans un tableau: \n 002 ";
            m_canvasG.alpha = 1;
            isRecup3 = true;
        }


        if (Input.GetKeyDown(KeyCode.P)) { m_canvasG.alpha = 0; isOk = false; }
    }

    void choiseSummary()
        //en fonction du numéro du livre on va choisir quel résumé afficher
    {
        switch (m_iBookNumber)
        {
            case 1:
                m_TextAAfficher.text = "La quatrième de couverture dit:\n C'est l'histoire d'une \nfemme mal mariée,\n de son médiocre époux, de \nses amants égoïstes\n et vains, de ses rêves,\n de ses chimères,\n de sa mort. \n\n Appuyez sur P pour partir.";
                break;
            case 2:
                m_TextAAfficher.text = "La quatrième de couverture dit:\n  Fils de charpentier, \nJulien Sorel est trop \nsensible et trop \nambitieux pour suivre la \ncarrière familiale dans la \nscierie d’une petite \nville de province. \n\n Appuyez sur P pour partir.";
                break;
            case 3:
                m_TextAAfficher.text = "La quatrième de couverture dit:\nDans la France chaotique\n du XIXe siècle, Jean \nValjean sort de prison. \n\n Appuyez sur P pour partir.";
                break;
            case 4:
                m_TextAAfficher.text = "La quatrième de couverture dit:\nLe monde est une mascarade \noù le succès va de \npréférence aux crapules. \n\n Appuyez sur P pour partir.";
                break;
            default:
                m_TextAAfficher.text = "Pas de résumé pour ce livre.";
                break;
        }
        
    }

     void choisePaperTexte()
        //on affichera le texte sur le papier
    {
        if (_MGR_ScenarioManager.p_num_etapeEnCours == 0 && m_gameObject.CompareTag("paperIndiceFinal"))
        {
            m_TextAAfficher.text = "0 7 9 \n\n\n Appuyez sur P pour partir.";
           isRecup1 = true;

        }
        

        if (_MGR_ScenarioManager.p_num_etapeEnCours == 0 && m_gameObject.CompareTag("paper"))
        {
            m_TextAAfficher.text = " La porte se trouve derrière vous . \n\n\n Appuyez sur P pour partir.";
            openDoor = true;
            
        }

        if (_MGR_ScenarioManager.p_num_etapeEnCours == 1 && m_gameObject.CompareTag("paperIndiceFinal"))
        {
            m_TextAAfficher.text = "1 6 4 \n\n\n Appuyez sur P pour partir.";
            isRecup2 = true;
            
        }
    }

    private void OnMouseDown()
    {
        if (distance < maxDistance) isOk = true;
    }
}
