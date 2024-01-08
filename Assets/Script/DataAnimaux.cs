using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Animal0", menuName = "Animaux")]
public class DataAnimaux : ScriptableObject
{
    public string nom;
    public float indicateurAugment;
    public Sprite imageAnimal;
}
