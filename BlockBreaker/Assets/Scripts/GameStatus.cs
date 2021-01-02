using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{

    [Range(0.1f,10f)][SerializeField] float gameSpeed = 1.0f;
    [SerializeField] int pointsPerBlock = 83;
    [SerializeField] static int currentScore;
    [SerializeField] TextMeshProUGUI scoreDisplay;

    public int Length { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        scoreDisplay.text = currentScore.ToString();
    }
    public void CurrentScore() {
        currentScore += pointsPerBlock;
    }

    private void Awake()
    {
        int gameStausCount = FindObjectOfType<GameStatus>().Length;
    }
}
