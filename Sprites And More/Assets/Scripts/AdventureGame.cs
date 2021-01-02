using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the class that represents the variable aspect -- Text --
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //Using serializablefield make life easier by letting us assign value to variable inside UNITY rather  than making us switch back and forth!
    [SerializeField] Text textComponent;

    [SerializeField] State startingState;
    State state;
    string str = "I am adde programicatly";

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        //The statement access textComponent's text method using dot operator that actually returns the string

        //In short when we assign a text component to our variable textComponent we will be able to access it's value directly yet indirectly
        textComponent.text = state.getStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        
    }

    private void ManageState(){

        var nextStates = state.getNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
   
        textComponent.text = state.getStoryText();
    }
}
