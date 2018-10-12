using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreText : MonoBehaviour {


    int score = 0;
    string scoreText = "0";

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();    
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Added: " + amount);
    }

    public void SetText()
    {
        scoreText = "" + score;
    }

	void Update () {
        SetText();
        text.text = "Score: " + scoreText;
	}
}
