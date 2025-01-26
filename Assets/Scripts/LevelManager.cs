using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private LayoutManager layoutManager;
    [SerializeField] private int ExplodeBubbleCount = 0;
    [SerializeField] private GameTimer gameTimer;

    public void Start()
    {
        layoutManager = FindObjectOfType<LayoutManager>();
        gameTimer = FindObjectOfType<GameTimer>();
        Time.timeScale = 1;
        print("Level: " + DATA.level);
    }

    public void ExplodeBubble()
    {
        ExplodeBubbleCount++;
        if (ExplodeBubbleCount >= layoutManager.count)
        {
            CompleteLevel(); // Llamamos a CompleteLevel cuando el nivel se complete
        }
    }

    public void CompleteLevel()
    {
        // Marcar el nivel como completado
        switch (DATA.level)
        {
            case 1: DATA.Trophy1 = true; break;
            case 2: DATA.Trophy2 = true; break;
            case 3: DATA.Trophy3 = true; break;
            case 4: DATA.Trophy4 = true; break;
            case 5: DATA.Trophy5 = true; break;
            case 6: DATA.Trophy6 = true; break;
            case 7: DATA.Trophy7 = true; break;
            case 8: DATA.Trophy8 = true; break;
            case 9: DATA.Trophy9 = true; break;
            case 10: DATA.Trophy10 = true; break;
        }

        // Llamar a OnLevelCompleted para cambiar el sprite y habilitar el siguiente nivel
        FindObjectOfType<MainMenu>().OnLevelCompleted(); // Aqu� cambiaremos el sprite y habilitaremos el siguiente nivel

        // Incrementar el nivel solo despu�s de cambiar el sprite y habilitar el siguiente nivel
        DATA.level++;

        // Llamar al temporizador para indicar que el nivel ha sido ganado
        gameTimer.WinLevel();
    }

    public void ToSelectLevel(int level)
    {
        DATA.level = level;
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void ToTrophies()
    {
        SceneManager.LoadScene("Trophies", LoadSceneMode.Single);
    }

    public void ToNextLevel()
    {
        SceneManager.LoadScene(DATA.level, LoadSceneMode.Single);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
