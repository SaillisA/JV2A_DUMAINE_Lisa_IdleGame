using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AnimalerieScript : MonoBehaviour
{

    public ClickerScript score;
    public int prix = 0;
    public TextMeshProUGUI affichePrix;
    public GameObject boutonAcheter;

    
    public List<DataAnimaux> listeAnimaux;  //liste qui prends des DataAnimaux
    public List<int> listCompteurAnimale;   //liste qui fait en sorte qu'on ne puisse pas tirer plus de 3 fois le même animale
    public int indiceAnimalListe;
    public List<Image> listeBureaux;   //liste qui prends des GameObject "bureaux", pour pouvoir placer les animaux
    public int indiceBureauListe;


    public GameObject clickerCanva;

    public Image imageAnimaleAchete;            //pour afficher le personnage que le jouer a recuperer
    public TextMeshProUGUI texteAnimaleAchete;
    public GameObject boutonAnimalAchete;      //pour desactiver le bouton

    public int fouetPrix = 1000;
    public int nombreFouet = 5;
    public TextMeshProUGUI prixFouet;

    // Start is called before the first frame update
    void Start()
    {
        affichePrix.text = prix + "$";
        prixFouet.text = fouetPrix + "$";
        boutonAnimalAchete.gameObject.SetActive(false);
        imageAnimaleAchete.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AchatAnimal()
    {
        //on verifie si la liste d'animaux et la liste de bureaux ne sont pas inférieur à 0. Si c'est le cas pour l'un des deux, le joueur ne peut pas prendre plus d'animaux
        if (listeAnimaux.Count > 0 && listeBureaux.Count > 0)
        {
            //on verifie si le joueur a assez d'argent pour acheter un animal
            if (score.scoreCompteur >= prix)
            {

                indiceAnimalListe = Random.Range(0, listeAnimaux.Count);
                Debug.Log(indiceAnimalListe);

                if (listCompteurAnimale[indiceAnimalListe] <= 0)
                {
                    //On a déjà au l'animal 3 fois 
                    Debug.Log("on supprime l'animal");
                    listeAnimaux.RemoveAt(indiceAnimalListe);
                    listCompteurAnimale.RemoveAt(indiceAnimalListe);

                }
                else
                {
                    //On garde l'animal
                    listCompteurAnimale[indiceAnimalListe] -= 1;
                    Debug.Log("Achat : " + listeAnimaux[indiceAnimalListe].nom);

                    
                    //On le place sur un bureau
                    indiceBureauListe = Random.Range(0, listeBureaux.Count);
                    listeBureaux[indiceBureauListe].color = new Color(1f, 1f, 1f, 1f);
                    listeBureaux[indiceBureauListe].sprite = listeAnimaux[indiceAnimalListe].imageAnimal;
                    listeBureaux.RemoveAt(indiceBureauListe);

                    //On l'affiche
                    boutonAnimalAchete.gameObject.SetActive(true);
                    imageAnimaleAchete.gameObject.SetActive(true);
                    imageAnimaleAchete.sprite = listeAnimaux[indiceAnimalListe].imageAnimal;
                    texteAnimaleAchete.text = "Bravo ! Vous avez eu " + listeAnimaux[indiceAnimalListe].nom;

                    //On incremente le multiplicateur de l'autoclick
                    score.multiplicateurAutoclick += listeAnimaux[indiceAnimalListe].indicateurAugment;
                    Debug.Log("multiplicateur :"+score.multiplicateurAutoclick);

                    //prix
                    score.scoreCompteur -= prix;
                    prix *= 2;
                    affichePrix.text = prix + "$";
                }

            }

        }
        else
        {
            affichePrix.text = "Vous ne pouvez pas acheter plus d'animaux";
            Destroy(boutonAcheter);
        }
    }

    public void AchatFouet()
    {
        if(nombreFouet > 0)
        {
            if(score.scoreCompteur >= fouetPrix)
            {
                Debug.Log("fouet accheter");
                score.scoreCompteur -= fouetPrix;
                fouetPrix *= 10;
                nombreFouet -= 1;
                prixFouet.text = fouetPrix + "$";
                score.AmeliorerFrequenceAutoClick();
            }
            
        }
        else
        {
            prixFouet.text = ("Vous ne pouvez pas en achetez plus, attention au PETA");
        }
    }


    public void ValidationAnimalAchete()
    {
        boutonAnimalAchete.gameObject.SetActive(false);
        imageAnimaleAchete.gameObject.SetActive(false);
    }
}
