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
        StartCoroutine(makeNearbyFalse());
    }
    
    IEnumerator makeNearbyFalse()
    {
        yield return new WaitForSeconds(5f);
        nearby = false;
    }

    private void OnTriggerExit(Collider other)
    {
        nearby = false;
    }

    void OnGUI()
    {
        thisStyle.fontSize = 55;
        thisStyle.normal.textColor = Color.yellow;
        if (nearby)
        {
            GUI.Box(new Rect(20, 250, 300, 25), "I've heard the j button is quite useful...", thisStyle);
        }
    }
}
