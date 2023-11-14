using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public Button backMainMenu;
    void Start()
    {
        Button backtoMenu = backMainMenu.GetComponent<Button>();
    }

    public void backMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
