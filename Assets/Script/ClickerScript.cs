using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickerScript : MonoBehaviour
{
    
    //valeur de click
    public int clickerValeur = 1;
    public TextMeshProUGUI afficheClickerValeur;

    //score
    public int scoreCompteur;
    public TextMeshProUGUI score;

    //autoclick
    public bool autoClickActiver = false;
    public TextMeshProUGUI messageBoutonAutoClick;
    public TextMeshProUGUI afficheAutoClickFrequence;
    public int frequenceAutoClick = 5;


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
            yield return new WaitForSeconds(frequenceAutoClick);
        }
        
    }
    
    public void ClickerCliquer()
    {
        scoreCompteur= scoreCompteur + clickerValeur;
        
    }

    public void AugmenterClickerValeur()
    {
        clickerValeur = clickerValeur * 2;
        afficheClickerValeur.text = clickerValeur + " ppp";
    }

    public void ActiverDescativerAutoClicker()
    {
        if(autoClickActiver == true)
        {
            messageBoutonAutoClick.text = "AutoClick : Desactiver";
            autoClickActiver = false;
        }
        else 
        {
            messageBoutonAutoClick.text = "AutoClick : Activer";
            autoClickActiver = true; 
        }


    }
    public void AmeliorerFrequenceAutoClick()
    {
        if(frequenceAutoClick > 0)
        {
            frequenceAutoClick -= 1;
            afficheAutoClickFrequence.text = "Toutes les " + frequenceAutoClick + " secondes";
        }       
        else
        {
            afficheAutoClickFrequence.text = "Toutes les " + frequenceAutoClick + " seconde. Vous etes au maximum"; 
        }
    }
}
