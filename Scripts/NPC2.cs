using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : MonoBehaviour
{
    private bool nearby = false;
    private GUIStyle thisStyle = new GUIStyle();
    public GameObject npc;
    private Animator _animator;
    private string hint;

    void Awake()
    {
        _animator = npc.GetComponent<Animator>();
    }

    void Update()
    {
        if (nearby)
        {
            _animator.SetBool("Nearby", nearby);
        }
        else
        {
            _animator.SetBool("Nearby", nearby);
        }

        if (Time.timeSinceLevelLoad > 600)
        {
            hint = "The last treasure you seek...\nI see visions of mountains, of secrets...";
        }

        else
        {
            hint = "A hint from me? Try for yourself!\nCome back later if you still need help...";
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
            GUI.Box(new Rect(20, 110, 310, 60), hint, thisStyle);
        }
    }
}