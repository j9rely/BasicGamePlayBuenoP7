using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddLives(int value)
    {
        lives += value;

        if (lives <=0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Livess = " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}