using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class DetectWater : MonoBehaviour
{
    public static bool water = false;
    public GameObject player;
    public GameObject surface;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            water = true; 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (water && other.tag == "Player")
        {
            water = false;
        }
    }
}
