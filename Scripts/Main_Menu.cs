using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{

    public Button start_button;
    public Button instructions_button;
    void Start()
    {
        Button start = start_button.GetComponent<Button>();
        Button instructions = instructions_button.GetComponent<Button>();
    }

    public void game_start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TreasureHunt");
    }

    public void instructions_open()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instructions");
    }
}
