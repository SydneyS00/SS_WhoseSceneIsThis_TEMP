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

    public void DisplayEvidence()
    {
        int i = 0;
        int index = i % textComponents.Count;
        int checkCount = 0;

        while (textComponents[index].enabled == true && checkCount < textComponents.Count)
        {
            index = (index + 1) % textComponents.Count;
            checkCount++;
        }

        textComponents[index].enabled = true;
    }
}




