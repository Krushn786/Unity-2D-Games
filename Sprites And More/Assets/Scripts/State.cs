using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This will help you make state object in Unity when you right click!
//The reason it helps is a way where you don't have to create a class for every single state rather you can just create a object!
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //This will make the field editable in UNITY itself!
    [TextArea(10, 14)] [SerializeField] string storytext;
    [SerializeField] State[] nextStates;

    //This method returns the value stored in storyText vairable
    public string getStoryText() {
        return storytext;
    }

    public State[] getNextStates() {
        return nextStates;
    }
}
