using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    [SerializeField] float screenUnit = 16.0f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = (Input.mousePosition.x / Screen.width) * screenUnit;

        //This will let the paddle move on x-axis as the mouse moves, but keep it set on y-axis so it doesn't move up!

        //We will keep the same position
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        //We will check if the paddle will cross the boundries or not! If they do than will put paramaters
        //We will change the x position value!
        paddlePos.x = Mathf.Clamp(mousePos, minX, maxX);
        transform.position = paddlePos;
    }
}
