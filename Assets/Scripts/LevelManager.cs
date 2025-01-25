using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string nextSceneName;
    [SerializeField] private LayoutManager layoutManager;
    [SerializeField] private int ExplodeBubbleCount = 0;


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
        DATA.Trophy1 = true;
        SceneManager.LoadScene(nextSceneName);
    }
}