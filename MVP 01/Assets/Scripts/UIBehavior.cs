using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIBehavior : MonoBehaviour
{
    //This script will act as a manager for all of the UI elements in our scene

    //VOTE UI VARIABLES
    Button OptionA;
    Button OptionB;
    Button OptionC;

    //MAIN MENU UI VARIABLES
    Button StartButton; 

    //Planning on figuring out how to implement a random variable for which button 
    //  is the correct one
    public void ClickedA()
    {
        Debug.Log("The dirty cop got away! YOU LOSE");
        SceneManager.LoadScene("LosingScene"); 
    }

    public void ClickedB()
    {
        Debug.Log("You caught the dirty cop! YOU WON!");
        SceneManager.LoadScene("WinScene"); 
    }

    public void ClickedC()
    {
        Debug.Log("The dirty cop got away! YOU LOSE");
        SceneManager.LoadScene("LosingScene"); 
    }


    //Main Menu UI
    public void StartGame()
    {
        Debug.Log("We are starting the game");
        SceneManager.LoadScene("GameScene"); 
    }

    public void PullInstructions()
    {
        Debug.Log("We are looking up the instructions");
        SceneManager.LoadScene("InstructionScene");
    }

    //Instructions
    public void StartGameInstructions()
    {
        Debug.Log("We are starting the game");
        SceneManager.LoadScene("GameScene");
    }

    public void ReturnToMenu()
    {
        Debug.Log("We are returning to the main screen");
        SceneManager.LoadScene("StartScreen");
    }

    //Losing and Winning Screen UI
    public void ReturnToMain()
    {
        Debug.Log("We are returning to the main menu");
        SceneManager.LoadScene("StartScreen");
    }
}
