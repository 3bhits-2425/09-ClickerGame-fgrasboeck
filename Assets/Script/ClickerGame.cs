using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClickerGame : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    private int clickPower = 1;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore()
    {
        score += clickPower;
        UpdateScoreText();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("score", 0);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
