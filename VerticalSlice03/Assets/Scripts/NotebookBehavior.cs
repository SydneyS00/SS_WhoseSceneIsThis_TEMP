using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class NotebookBehavior : MonoBehaviour
{
    //This script is responsible for the functionality of the police notebook
    //Here are some things that the book will do: 
    //  Display the evidence after each card is pulled 

    //VARIABLES//
    public bool cardBeenPlayed;
    public int evidenceDeckSize;

    public TextMeshProUGUI evidenceText; 


    private GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>(); 
    }

    void OnMouseDown()
    {
        if(cardBeenPlayed == false)
        {
            evidenceText.enabled = true; 
            cardBeenPlayed = true;
            
            
        }
    }




}
