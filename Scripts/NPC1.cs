using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    private bool nearby = false;
    private GUIStyle thisStyle = new GUIStyle();
    public GameObject npc;
    private Animator _animator;
    public static bool hasSpoken;
    void Awake()
    {
        _animator = npc.GetComponent<Animator>();
    }

    void Update()
    {
        if (nearby)
        {
            _animator.SetBool("Nearby", nearby);
            hasSpoken = true;
        }
        else
        {
            _animator.SetBool("Nearby", nearby);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        nearby = true;
    }

    private void OnTriggerExit(Collider other)
    {
        nearby = false;
    }

    void OnGUI()
    {
        thisStyle.fontSize = 20;
        if (nearby)
        {
            GUI.Box(new Rect(20, 110, 300, 25), "I've heard the j button is quite useful...", thisStyle);
        }
    }
}
