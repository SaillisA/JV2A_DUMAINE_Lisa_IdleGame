using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

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
    public int multiplicateurAutoclick = 1;       //multiplicateur qui s'incrémentera quand le joueur achetera un animal
    private int multiplicateurAutoclickFinale;       //autoclick finale avec le multiplicateur calculé

    public GameObject boutonTuto;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoroutineTestotest());
    }

    // Update is called once per frame
    void Update()
    {
        //score
        score.text =scoreCompteur + " $";
    }
    
    public IEnumerator CoroutineTestotest()
    {
        while(true)
        {
            if ( autoClickActiver == true)
            {
                multiplicateurAutoclickFinale = (clickerValeur/2) * multiplicateurAutoclick;
                scoreCompteur += multiplicateurAutoclickFinale;
            }
            yield return new WaitForSeconds(frequenceAutoClick);
        }
        
    }
    
    public void ClickerCliquer()
    {
        scoreCompteur= scoreCompteur + clickerValeur;
        
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

    public void FermerFenetreTuto()
    {
        Destroy(boutonTuto);
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
