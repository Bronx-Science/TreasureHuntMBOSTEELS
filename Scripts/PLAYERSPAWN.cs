using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERSPAWN : MonoBehaviour
{
    public GameObject player;
    private float startTime;
    private string label;
    private GUIStyle thisStyle = new GUIStyle();

    void Start()
    {
        player.transform.position = new Vector3(202,325,792);
        player.transform.Rotate(0,180,0);
        startTime = Time.time;
    }

    void Update()
    {
        label = "TIME REMAINING: " + Math.Round((decimal) (900 - (Time.time - startTime)), 1);
        if (900 - (Time.time - startTime) <= 0)
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    void OnGUI()
    {
        thisStyle.fontSize = 20;
        GUI.Box(new Rect(20, 20, 2000, 1000), label, thisStyle);
    }
   
}
