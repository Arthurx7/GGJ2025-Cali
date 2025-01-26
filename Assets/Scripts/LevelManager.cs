using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private LayoutManager layoutManager;
    [SerializeField] private int ExplodeBubbleCount = 0;
    [SerializeField] private GameTimer gameTimer;

    public void Start(){
        layoutManager = FindObjectOfType<LayoutManager>();
        gameTimer = FindObjectOfType<GameTimer>();
    }

    public void ExplodeBubble()
    {
        ExplodeBubbleCount++;
        if (ExplodeBubbleCount >= layoutManager.count)
        {
            CompleteLevel();
        }
    }
    public void CompleteLevel()
    {
        switch (DATA.level)
        {
            case 1:
                DATA.Trophy1 = true;
                break;
            case 2:
                DATA.Trophy2 = true;
                break;
            case 3:
                DATA.Trophy3 = true;
                break;
            case 4:
                DATA.Trophy4 = true;
                break;
            case 5:
                DATA.Trophy5 = true;
                break;
            case 6:
                DATA.Trophy6 = true;
                break;
            case 7:
                DATA.Trophy7 = true;
                break;
            case 8:
                DATA.Trophy8 = true;
                break;
            case 9:
                DATA.Trophy9 = true;
                break;
            case 10:
                DATA.Trophy10 = true;
                break;
        }
        DATA.level++;
        gameTimer.WinLevel();
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
    }

    public void ToTrophies()
    {
        SceneManager.LoadScene("Trophies", LoadSceneMode.Single);
    }

    public void ToNextLevel()
    {
       // SceneManager.LoadScene(DATA.level, LoadSceneMode.Single);
       Debug.Log("Next Level:"+ DATA.level);
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}       