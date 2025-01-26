using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button[] bots;
    public Sprite completedLevelSprite; // Sprite que indica nivel completado

    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectsOfType<MainMenu>().Length > 1)
        {
            Destroy(gameObject); // Si ya existe, destruye este objeto
            return;
        }
        // Prevenir que el objeto sea destruido al cambiar de escena
        DontDestroyOnLoad(this.gameObject);

        if (!DATA.once)
        {
            DATA.set_once();
        }

        // Inicializamos los botones
        for (int i = 0; i < bots.Length; i++)
        {
            bots[i].interactable = false;
        }

        // Activamos los botones que corresponden a los niveles completados
        for (int i = 0; i < DATA.level; i++)
        {
            bots[i].interactable = true;
        }

        // Cambiar el sprite de los niveles completados al inicio
        for (int i = 0; i < DATA.level; i++)
        {
            SetLevelCompleted(i);
        }
    }

    // Cambia el sprite de un botón para indicar que el nivel está completado
    public void SetLevelCompleted(int levelIndex)
    {
        if (levelIndex < bots.Length)
        {
            Image buttonImage = bots[levelIndex].GetComponent<Image>();
            if (buttonImage != null && completedLevelSprite != null)
            {
                buttonImage.sprite = completedLevelSprite;
            }
        }
    }

}
