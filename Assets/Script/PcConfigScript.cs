using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PcConfigScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ClickerScript clicker;

    //Tableaux
    public int[] tableauAmeliorationEcran, tableauPrixEcran;
    public int[] tableauAmeliorationSouris, tableauPrixSouris;
    public int[] tableauAmeliorationClavier, tableauPrixClavier;
    public Sprite[] tableauSpriteEcran, tableauSpriteSouris, tableauSpriteClavier;
    
    public int niveauEcran = 1, niveauSouris = 1, niveauClavier =1;

    //boutons
    public GameObject boutonAchatEcran, boutonAchatSouris, boutonAchatClavier;

    public Image emplacementEcran, emplacementSouris, emplacementClavier;
    public TextMeshProUGUI prixEcran, prixClavier, prixSouris;
    void Start()
    {
        prixClavier.text = tableauPrixClavier[niveauClavier - 1]+"";
        prixEcran.text = tableauPrixEcran[niveauEcran - 1] + "";
        prixSouris.text = tableauPrixSouris[niveauSouris - 1] + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AmeliorationClavier()
    {
        if (clicker.scoreCompteur >= tableauPrixClavier[niveauClavier-1] )       //decremente le niveau pour pas qu'il y ai l'erreur out of range
        {
            emplacementClavier.sprite = tableauSpriteClavier[niveauClavier-1];
            clicker.clickerValeur += tableauAmeliorationClavier[niveauClavier - 1];
            if(niveauClavier == 2 ) { clicker.clickerValeur -= tableauAmeliorationClavier[0]; };
            if (niveauClavier == 3) { clicker.clickerValeur -= tableauAmeliorationClavier[1]; };
            if (niveauClavier == 4) { clicker.clickerValeur -= tableauAmeliorationClavier[2]; };
            if (niveauClavier == 5) { clicker.clickerValeur -= tableauAmeliorationClavier[3]; };


            clicker.afficheClickerValeur.text = +clicker.clickerValeur+ "";
            clicker.scoreCompteur -= tableauPrixClavier[niveauClavier - 1];

            niveauClavier++;
            if (niveauClavier == 6)                                                                    //si le joueur possede le clavier niveau 5, il ne peut plus l'ameliorer car celui est au niveau max
            {
                Debug.Log("On supprime le bouton pour acheter le clavier");
                Destroy(boutonAchatClavier);
            }
            else 
            {
                prixClavier.text = tableauPrixClavier[niveauClavier - 1] + ""; 
            }
           
        }
    }
    public void AmeliorationSouris()
    {
        if (clicker.scoreCompteur >= tableauPrixSouris[niveauSouris - 1])       //decremente le niveau pour pas qu'il y ai l'erreur out of range
        {
            emplacementSouris.sprite = tableauSpriteSouris[niveauSouris-1];
            clicker.clickerValeur += tableauAmeliorationSouris[niveauSouris - 1];
            if (niveauSouris == 2) { clicker.clickerValeur -= tableauAmeliorationSouris[0]; };
            if (niveauSouris == 3) { clicker.clickerValeur -= tableauAmeliorationSouris[1]; };
            if (niveauSouris == 4) { clicker.clickerValeur -= tableauAmeliorationSouris[2]; };
            if (niveauSouris == 5) { clicker.clickerValeur -= tableauAmeliorationSouris[3]; };


            clicker.afficheClickerValeur.text = +clicker.clickerValeur + "";
            clicker.scoreCompteur -= tableauPrixSouris[niveauSouris - 1];

            niveauSouris++;
            if (niveauSouris == 6)                                                                    //si le joueur possede la souris niveau 5, il ne peut plus l'ameliorer car celui est au niveau max
            {
                Debug.Log("On supprime le bouton pour acheter la souris");
                Destroy(boutonAchatSouris);
            }
            else
            {
                prixSouris.text = tableauPrixSouris[niveauSouris - 1] + "";
            }
        }
    }
    public void AmeliorationEcran()
    {
        if (clicker.scoreCompteur >= tableauPrixEcran[niveauEcran - 1])       //decremente le niveau pour pas qu'il y ai l'erreur out of range
        {
            emplacementEcran.sprite = tableauSpriteEcran[niveauEcran-1];
            clicker.clickerValeur += tableauAmeliorationEcran[niveauEcran - 1];
            if (niveauEcran == 2) { clicker.clickerValeur -= tableauAmeliorationEcran[0]; };
            if (niveauEcran == 3) { clicker.clickerValeur -= tableauAmeliorationEcran[1]; };
            if (niveauEcran == 4) { clicker.clickerValeur -= tableauAmeliorationEcran[2]; };
            if (niveauEcran == 5) { clicker.clickerValeur -= tableauAmeliorationEcran[3]; };


            clicker.afficheClickerValeur.text = +clicker.clickerValeur + "";
            clicker.scoreCompteur -= tableauPrixEcran[niveauEcran - 1];

            niveauEcran++;
            if (niveauEcran == 6)                                                                    //si le joueur possede l'ecran niveau 5, il ne peut plus l'ameliorer car celui est au niveau max
            {
                Debug.Log("On supprime le bouton pour acheter lecran");
                Destroy(boutonAchatEcran);
            }
            else
            {
                prixEcran.text = tableauPrixEcran[niveauEcran - 1] + "";
            }
        }
    }
}
