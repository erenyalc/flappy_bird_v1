using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public int score;
    public TMPro.TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        int score = 0;
        scoreText.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);

    }
}
