using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string nextSceneName;
    [SerializeField] private LayoutManager layoutManager;
    [SerializeField] private int ExplodeBubbleCount = 0;
    [SerializeField] private int level = 0;


    public void ExplodeBubble()
    {
        ExplodeBubbleCount++;
        if (ExplodeBubbleCount >= layoutManager.count)
        {
            CompleteLevel(level);
        }
    }
    public void CompleteLevel(int Level)
    {
        switch (Level)
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
        }
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }

    public void ToScene(int Level){
        level = Level;
        SceneManager.LoadScene(Level, LoadSceneMode.Single);

    }

    public void ToLevelSelection(){
        SceneManager.LoadScene("LevelSelection", LoadSceneMode.Single);
    }

    public void ToTutorial(){
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }
}