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

    //Variables//
    public List<TextMeshProUGUI> textComponents;
    void Start()
    {
        //Disable all the text components at the beginning of the game
        foreach (TextMeshProUGUI textComponent in textComponents)
        {
            //textComponent.gameObject.SetActive(false);
            textComponent.enabled = false; 
            Debug.Log("Currently we have no evidence"); 
        }
    }


    public void ShowText()
    {
        int randomNum = Random.Range(0, textComponents.Count);
        int checkCount = 0;

        while (textComponents[randomNum].enabled == true && checkCount < textComponents.Count)
        {
            randomNum = Random.Range(0, textComponents.Count);
            checkCount++;
        }

        textComponents[randomNum].enabled = true;
    }



}
