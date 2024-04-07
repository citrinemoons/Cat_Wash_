using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject Checklist; 

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();


    }

    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Intro Scene");
    }

    public void Go()
    {   
        SceneManager.LoadScene("Cat Wash");
    }

    public void BackToMain()
    {
        //I feel like this is pretty self explaining, but, this lets players out of options back to the main menu
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Debug.Log("Bye for now :3");
        Application.Quit();
    }


    public void ChecklistButton()
    {
        gameObject.SetActive(true);
    }

    public void BackToWash()
    {
        gameObject.SetActive(false);
    }
}

