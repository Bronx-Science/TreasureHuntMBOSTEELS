using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadPlayer : MonoBehaviour
{
    public static float jumpMax = 50;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Jump Pad")
        {
            Debug.Log("Collision detected");
            StarterAssets.ThirdPersonController.JumpHeight = jumpMax;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "Jump Pad")
        {
            Debug.Log("Jump height back to normal");
            StarterAssets.ThirdPersonController.JumpHeight = 2.2f;
        }
    }
}
