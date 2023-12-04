using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementLieux : MonoBehaviour
{
    public bool dansClickers = false;
    public bool dansBoutique = false;

    //public Canvas clikersCanvas;

    public GameObject clickerCanva;
    //public Canvas clikersCanvas;
    public Canvas boutiqueCanvas;


    // Start is called before the first frame update
    void Start()
    {
        dansClickers = true;
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
        if (!dansClickers)
        {
            Debug.Log("onepludanboutique");
        }

    }
}
