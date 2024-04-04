using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static int score;
    public static int lives = 3;

    public TMP_Text scoreText;
    public TMP_Text livesText;

    public GameObject winScreen;
    public GameObject loseScreen;
    private void Update()
    {
        scoreText.text = "Score : " + score;
        livesText.text = "Lives : " + lives;

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            enabled = false;
        }

        if (FindObjectsOfType<Brick>().Length < 1)
        {
            winScreen.SetActive(true);
            enabled = false;
        }
    }
    public void FullReset()
    {
        SceneManager.LoadScene("SampleScene");
        lives = 3;
        score = 0;
        scoreText.text = $"Score:{score}";
        livesText.text = $"Lives:{lives}";
    }
}
