using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //We will link our paddle script to this variable!
    [SerializeField] Paddle paddle1;
    [SerializeField] float rigidbody2DBounceX = 2f;
    [SerializeField] float rigidbody2DBounceY = 15f;
    [SerializeField] AudioClip[] BallAudio;

    //This will calculate the paddle-transform-position
    Vector2 paddleToBall;

    //Check if the player made a click yet
    private bool clickedOrNot = false;


    //Getting AudioSource One and For All

    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        paddleToBall = transform.position - paddle1.transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!clickedOrNot)
        {
            ballPosBeforeClick();
            ballPosAfterClick();

        }

    }

    private void ballPosAfterClick() {
        if (Input.GetMouseButtonDown(0))
        {
            clickedOrNot = true;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(rigidbody2DBounceX, rigidbody2DBounceY);
    }

    private void ballPosBeforeClick()
    {
        //Every frame we might not know where our paddle is just we get the paddle position every frame
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);

        //Once the paddle position is achieved we will update our ball position!
        transform.position = paddlePos + paddleToBall;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (clickedOrNot)
        {
            AudioClip clip = BallAudio[UnityEngine.Random.Range(0, (BallAudio.Length))];
            audioSource.PlayOneShot(clip);
        }
    }
}
