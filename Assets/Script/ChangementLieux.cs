using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementLieux : MonoBehaviour
{
    public bool dansClickers = false;
    public bool dansBoutique = false;
    public bool dansAnimalerie = false;
    public bool dansPcConfig  = false;

    //public Canvas clikersCanvas;

    public GameObject clickerCanva, boutiqueCanvas, animalerieCanvas, pcConfigCanvas;


    // Start is called before the first frame update
    void Start()
    {
        //clicker
        dansClickers = true;
        clickerCanva.gameObject.SetActive(true);
        //autresCanva
        boutiqueCanvas.gameObject.SetActive(false);
        animalerieCanvas.gameObject.SetActive(false);
        pcConfigCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BoutonBoutique()
    {
        //dans le canva clicker, quand on clique sur le bouton boutique
        dansBoutique = true; dansClickers = false;
        clickerCanva.gameObject.SetActive(false);
        boutiqueCanvas.gameObject.SetActive(true);
    }
    public void BoutonClickerDepuisBoutique()
    {
        //dans le canva boutique, quand on clique sur le bouton clicker
        dansBoutique = false; dansClickers = true;
        boutiqueCanvas.gameObject.SetActive(false) ;
        clickerCanva.gameObject.SetActive(true) ;
    }
    public void BoutonAnimalerie()
    {
        //dans le canva boutique, quand on clique sur l'animalerie
        dansBoutique = false; dansAnimalerie = true;
        boutiqueCanvas.gameObject.SetActive(false) ;
        animalerieCanvas.gameObject.SetActive(true) ;
    }
    public void BoutonPcCongig()
    {
        //dans le canva boutique, quand on clique sur l'animalerie
        dansBoutique = false; dansPcConfig = true;
        boutiqueCanvas.gameObject.SetActive(false);
        pcConfigCanvas.gameObject.SetActive(true);
    }
    public void RevenirDansBoutique()
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
