using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickerScript : MonoBehaviour
{

    public GameObject clicker;
    
    //valeur de click
    public int clickerValeur = 1;
    public TextMeshProUGUI afficheClickerValeur;

    //score
    public int scoreCompteur;
    public TextMeshProUGUI score;

    //autoclick
    public bool autoClickActiver = false;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoroutineTestotest());
    }

    // Update is called once per frame
    void Update()
    {
        //score
        score.text = "" + scoreCompteur;
    }
    
    public IEnumerator CoroutineTestotest()
    {
        while(true)
        {
            if ( autoClickActiver == true)
            {
                scoreCompteur += clickerValeur;
            }
            yield return new WaitForSeconds(3);
        }
        
    }
    
    public void ClickerCliquer()
    {
        scoreCompteur= scoreCompteur + clickerValeur;
        
    }

    public void AugmenterClickerValeur()
    {
        clickerValeur = clickerValeur * 2;
        afficheClickerValeur.text = clickerValeur + " score/seconde";
    }

    public void ActiverDescativerAutoClicker()
    {
        if(autoClickActiver == true)
        {
            autoClickActiver = false;
        }
        else 
        {
            autoClickActiver = true; 
        }


    }
}
