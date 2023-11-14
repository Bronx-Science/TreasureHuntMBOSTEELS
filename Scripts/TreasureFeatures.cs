using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureFeatures : MonoBehaviour
{
    public GameObject cube;
    public GameObject Treasure;
    public float xRotate, yRotate, zRotate;
    void Update()
    {
        cube.transform.Rotate(xRotate,yRotate,zRotate);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Treasure.SetActive(false);
            CountTreasures.treasuresFound++;
            CountTreasures.Animate();
        }
    }
}
