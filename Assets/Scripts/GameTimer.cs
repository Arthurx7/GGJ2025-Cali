using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timerDuration = 30f; 
    private float currentTime;

    public Text timerText; 
    public GameObject defeatScreen; 
    public GameObject levelCompleteCanvas; 

    public GameObject pauseCanvas;

    private bool isGameActive = true;

    void Start()
    {
        currentTime = timerDuration;
        UpdateTimerUI();
    }

    void Update()
    {
        if (isGameActive)
        {
            currentTime -= Time.deltaTime;
            

            if (currentTime <= 0)
            {
                currentTime = 0;
                EndGame();
            }

            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = currentTime.ToString("00");
    }

    void EndGame()
    {
        isGameActive = false;
        defeatScreen.SetActive(true);
    }

    public void WinLevel()
    {
        isGameActive = false;
        levelCompleteCanvas.SetActive(true); 
    }

    public void PauseGame()
    {
        isGameActive = false;
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        isGameActive = true;
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
}