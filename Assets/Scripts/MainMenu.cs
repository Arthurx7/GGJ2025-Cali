using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button[] bots;
    public Sprite completedLevelSprite; // Sprite que indica nivel completado
    public Sprite initialLevelSprite;   // Sprite inicial para los botones (no completado)

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

        // Inicializa todos los botones con el sprite inicial
        for (int i = 0; i < bots.Length; i++)
        {
            bots[i].interactable = false;  // Inicialmente deshabilitar todos los botones
            Image buttonImage = bots[i].GetComponent<Image>();
            if (buttonImage != null && initialLevelSprite != null)
            {
                buttonImage.sprite = initialLevelSprite; // Asignamos el sprite inicial
            }
        }

        // Habilitar solo el primer botón (nivel 0) al inicio
        bots[0].interactable = true;
    }

    // Cambia el sprite de un botón para indicar que el nivel está completado
    public void SetLevelCompleted(int levelIndex)
    {
        if (levelIndex < bots.Length)
        {
            Image buttonImage = bots[levelIndex].GetComponent<Image>();
            if (buttonImage != null && completedLevelSprite != null)
            {
                buttonImage.sprite = completedLevelSprite; // Cambiar sprite a completado
            }
        }
    }

    // Llamado cuando un nivel se ha completado
    public void OnLevelCompleted()
    {
        // Cambiar el sprite del nivel completado (índice DATA.level - 1)
        SetLevelCompleted(DATA.level - 1); // Cambiar el sprite del nivel actual (índice DATA.level - 1)

        // Habilitar el siguiente nivel (botón con índice DATA.level)
        if (DATA.level < bots.Length)
        {
            bots[DATA.level].interactable = true; // Habilitar el siguiente nivel (índice DATA.level)
        }
    }
}
