using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textDialogue;
    public string[] lines;
    public float speed;
    public GameObject textBox;
    

    private int index;

    void Start()
    {
        textDialogue.text = string.Empty;
        StartDialogue();
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (textDialogue.text == lines[index])
            {
                NextLine();

            }
            else
            {

                StopAllCoroutines();
                textDialogue.text = lines[index];


            }

        }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(Sentence());

    }

    IEnumerator Sentence()
    {
        //This lets us type out each line at time 

        foreach (char c in lines[index].ToCharArray())
        {

            textDialogue.text += c;
            yield return new WaitForSeconds(speed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textDialogue.text = string.Empty;
            StartCoroutine(Sentence());

        }
        else
        {
            SceneManager.LoadScene("Fake Loading"); 
        }
    
       

    }
}