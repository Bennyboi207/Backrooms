using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    /*
     * UI Functions:
     * - Display score
     * - Display health
     * - Respond to pause key (display resume button)
     * - Respond to resume button
     * - Maintain gameOver state (or get from GameController)
     * - Display play again button when game ends (gameOver becomes true)
     * - Reset UI when restarting game
     */

    public string healthLabel = "Health: ";
    public string scoreLabel = "Score: ";
    public string restartPrompt = "Shall we play another game?";
    public string startPrompt = "Would you like to play a game?";

    public int initialHealth;
    public int initialScore;
    public bool gameOver;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI startPromptText;

    public KeyCode pauseKey = KeyCode.Pause;

    private int _health;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;

        _health = initialHealth;
        _score = initialScore;

        // Start Panel
        restartPromptText.text = restartPrompt;
        startPromptText.text = startPrompt;
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            PauseGame();
        }

        if (gameOver)
        {
            OfferNewGame();
        }
    }

    // Update is called once per frame
    public void UpdateHealth(int h)
    {
        _health += h;
        healthText.text = healthLabel + _health;
    }

    public void UpdateScore(int s)
    {
        _score += s;
        scoreText.text = scoreLabel + _score;
    }

    public void ButtonPlayYes()
    {
        Debug.Log(this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name);
    }

    public void ButtonPlayNo()
    {
        Debug.Log(this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name);
    }

    public void ButtonRestart()
    {
        Debug.Log(this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name);
    }

    public void ButtonPause()
    {
        Debug.Log(this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name);
    }

    public void ButtonQuit()
    {
        Debug.Log(this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name);
    }

    void EndGame()
    {
        Debug.Log(this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name);
    }

    private void PauseGame()
    {
        Debug.Log("PauseGame()");
    }

    private void OfferNewGame()
    {
        Debug.Log("OfferNewGame()");
    }
}
