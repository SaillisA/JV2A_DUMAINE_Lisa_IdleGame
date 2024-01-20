using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Animal0", menuName = "Animaux")]
public class DataAnimaux : ScriptableObject
{
    public string nom;
    public int indicateurAugment;
    public Sprite imageAnimal;
    public int compteurAchat = 3;
}
