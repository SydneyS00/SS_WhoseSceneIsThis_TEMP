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

    public GameObject voteScreen;

    public GameObject FrontPage;
    public GameObject Page01;
    public GameObject Page02;
    public Button OpenNotebookButton; 
    public Button Page01Button;
    public Button Page02Button;
    public Button CloseNotebookButton; 

    //MAIN MENU UI VARIABLES
    Button StartButton; 

    //Game Screen
    public void PullVoteScreen()
    {
        voteScreen.SetActive(true); 
    }

    public void CloseVoteScreen()
    {
        voteScreen.SetActive(false); 
    }

    public void pullNotes()
    {
        Debug.Log("Here is all of the notes that we have gathered.");
    }

    public void OpenNotebook()
    {
        FrontPage.SetActive(false);
        Page01.SetActive(true);

        Page01Button.gameObject.SetActive(true);
        Page02Button.gameObject.SetActive(true);
        OpenNotebookButton.gameObject.SetActive(false);
        CloseNotebookButton.gameObject.SetActive(true); 

        Debug.Log("We have opened the notebook"); 
    }

    public void CloseNotebook()
    {
        FrontPage.SetActive(true);
        Page01.SetActive(false);
        Page02.SetActive(false);

        Page01Button.gameObject.SetActive(false);
        Page02Button.gameObject.SetActive(false);
        OpenNotebookButton.gameObject.SetActive(true);
        CloseNotebookButton.gameObject.SetActive(false); 
    }

    public void GoToPage01()
    {
        Page01.SetActive(true);
        Page02.SetActive(false); 
        Debug.Log("We have opened to page 1"); 
    }

    public void GoToPage02()
    {
        Page01.SetActive(false);
        Page02.SetActive(true);
        Debug.Log("We have opened to page 2");
    }

    //Voting Screen
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
