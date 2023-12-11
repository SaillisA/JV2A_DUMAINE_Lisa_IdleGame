using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementLieux : MonoBehaviour
{
    public bool dansClickers = false;
    public bool dansBoutique = false;
    public bool dansManagement = false;
    public bool dansAnimalerie = false;
    public bool dansPcConfig  = false;

    //public Canvas clikersCanvas;

    public GameObject clickerCanva, boutiqueCanvas, managementCanvas, animalerieCanvas, pcConfigCanvas;


    // Start is called before the first frame update
    void Start()
    {
        //clicker
        dansClickers = true;
        clickerCanva.gameObject.SetActive(true);
        //autresCanva
        boutiqueCanvas.gameObject.SetActive(false);
        managementCanvas.gameObject.SetActive(false);
        animalerieCanvas.gameObject.SetActive(false);
        pcConfigCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dansClickers)
        {
            Debug.Log("onedanclicker");
        }
        if (!dansClickers)
        {
            
            Debug.Log("onepludanclicker");
        }
        if (dansBoutique) 
        {
            Debug.Log("onedanboutique");
        }
        if (!dansBoutique)
        {
            Debug.Log("onepludanboutique");
        }

    }


    public void boutonBoutique()
    {
        //dans le canva clicker, quand on clique sur le bouton boutique
        dansBoutique = true; dansClickers = false;
        clickerCanva.gameObject.SetActive(false);
        boutiqueCanvas.gameObject.SetActive(true);
    }
    public void boutonManagement()
    {
        //dans le canva clicker, quand on clique sur le bouton management
        dansManagement = true; dansClickers = false;
        clickerCanva.gameObject.SetActive(false);
        managementCanvas.gameObject.SetActive(true);
    }
    public void boutonClickerDepuisBoutique()
    {
        //dans le canva boutique, quand on clique sur le bouton clicker
        dansBoutique = false; dansClickers = true;
        boutiqueCanvas.gameObject.SetActive(false) ;
        clickerCanva.gameObject.SetActive(true) ;
    }
    public void boutonClickerDepuisManagement()
    {
        //dans le canva management, quand on clique sur le bouton clicker
        dansClickers = true; dansManagement = false;
        managementCanvas.gameObject.SetActive(false);
        clickerCanva.gameObject.SetActive(true ) ;
    }
    public void boutonAnimalerie()
    {
        //dans le canva boutique, quand on clique sur l'animalerie
        dansBoutique = false; dansAnimalerie = true;
        boutiqueCanvas.gameObject.SetActive(false) ;
        animalerieCanvas.gameObject.SetActive(true) ;
    }
    public void boutonPcCongig()
    {
        //dans le canva boutique, quand on clique sur l'animalerie
        dansBoutique = false; dansPcConfig = true;
        boutiqueCanvas.gameObject.SetActive(false);
        pcConfigCanvas.gameObject.SetActive(true);
    }
    public void revenirDansBoutique()
    {
        if (dansAnimalerie)
        {
            dansAnimalerie = false; dansBoutique = true;
            animalerieCanvas.gameObject.SetActive(false) ;
            boutiqueCanvas.gameObject.SetActive(true) ;
        }
        if(dansPcConfig)
        {
            dansPcConfig = false; dansBoutique = true;
            pcConfigCanvas.gameObject.SetActive(false) ;
            boutiqueCanvas.gameObject.SetActive(true );
        }
    }
}
