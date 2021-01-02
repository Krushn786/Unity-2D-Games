using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess;

    // Start is called before the first frame update
    void Start()
    {

        
        Debug.Log("Welcome to the Number Wizard yo");
        Debug.Log("Pick a number, keep it in your mind..:");
        Debug.Log("Highest Number:" + max);
        Debug.Log("Lowest Number: " + min);

        guess = (min + max) / 2;

        Debug.Log("Tell me if I guess your number. Is it: " + guess);
        Debug.Log("If I  did press enter/return ");
        Debug.Log("If I was not able to tell me: ");
        Debug.Log("Is it higher if so press up_arrow ");
        Debug.Log("Is it lower if so press down_arrrow ");
        
            Update();
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up Arrow key was pressed:");
            min = (max + min) / 2;
            guess = (min + max) / 2;
            Debug.Log("Tell me if I guess your number. Is it: " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow key was pressed:");
            max = (min + max) / 2;
            guess = (min + max) / 2;
            Debug.Log("Tell me if I guess your number. Is it: " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Enter/Return key was pressed:");
            Debug.Log("Hooray... I guessed your number");
            Debug.Log("Let's restart press Q to quit");
        }




    }
}
