using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTreasures : MonoBehaviour
{
    public float countTreasures = 15;
    public static float treasuresFound = 0;
    public static Animator animator;
    public GameObject player;
    private GUIStyle style = new GUIStyle();
    public Texture boxTexture;
    void Start()
    {
        style.fontSize = 55;
        style.normal.textColor = Color.yellow;
        animator = player.GetComponent<Animator>();
    }
    public static void Animate()
    {
        animator.SetTrigger("TreasureFound");
    }
    public void OnGUI()
    {
        GUI.Box(new Rect(20, 90, 200, 25),"Treasures found: " + treasuresFound + " of 10", style);
    }
}
