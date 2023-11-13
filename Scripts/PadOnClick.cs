using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEditor.Rendering;
using UnityEngine;

public class PadOnClick : MonoBehaviour
{
    public GameObject pad;
    public GameObject player;
    private bool hasPressedJ;
    public static int countPads = 0;
    private string label;
    private GUIStyle thisStyle = new GUIStyle();

    void Start()
    {
        Debug.Log("Treasure Hunt scene loaded");
    }
    void Update()
    {
        if (Input.GetKey("j") && !hasPressedJ && NPC1.hasSpoken)
        {
            GameObject newJumpPad = Instantiate(pad);
            newJumpPad.transform.position = new Vector3(player.transform.position.x , player.transform.position.y-2,
                player.transform.position.z);
            hasPressedJ = true;
            countPads++;
            Destroy(newJumpPad, 10f);
        }
        else if (!Input.GetKey("j"))
            hasPressedJ = false;
    }
    
    void OnGUI()
    {
        thisStyle.fontSize = 20;
        if (NPC1.hasSpoken)
        {
            if (countPads <= 14)
                GUI.Box(new Rect(20, 80, 200, 30), "Jump Pads Remaining: " + (15 - countPads), thisStyle);
            else if (countPads > 14)
                GUI.Box(new Rect(20, 60, 250, 30), "No more jump pads available.", thisStyle);
        }
    }
}
