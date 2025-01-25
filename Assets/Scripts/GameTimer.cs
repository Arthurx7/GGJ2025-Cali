using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timerDuration = 30f; 
    private float currentTime;

    public Text timerText; 
    public GameObject defeatScreen; 
    public GameObject levelCompleteCanvas; 

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
}
