using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class JumpPad : MonoBehaviour
{
    public float jumpMax = 50;
    
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Debug.Log("Collision detected");
            StarterAssets.ThirdPersonController.JumpHeight = jumpMax;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Debug.Log("Jump height back to normal");
            StarterAssets.ThirdPersonController.JumpHeight = 2.2f;
        }
    }

    void OnDestroy()
    {
        PadOnClick.countPads--;
    }
}
