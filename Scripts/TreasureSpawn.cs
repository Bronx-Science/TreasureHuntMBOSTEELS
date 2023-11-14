using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TreasureSpawn : MonoBehaviour
{
    public GameObject treasure;
    public GameObject lastTreasure;
    private GameObject[] treasures = new GameObject[10];
    private Vector3[] positions = new Vector3[]
    {
        new Vector3(8,1,50),
        new Vector3(145, 1, 90),
        new Vector3(330, 1, 187),
        new Vector3(385, 1, 523),
        new Vector3(557, 1, 420),
        new Vector3(647, 1, 325),
        new Vector3(715, 1, 167),
        new Vector3(733, 7, 627),
        new Vector3(682, 49, 710),
        new Vector3(689.5f, 35, 908),
        new Vector3(644, 45, 937),
        new Vector3 (429, 1, 908),
        new Vector3 (245, 132, 828),
        new Vector3(315, 74, 900),
        new Vector3(439, 1, 745),
        new Vector3(564, 49, 442),
        new Vector3(705, 34, 433),
        new Vector3(786, 27, 372),
        new Vector3(795, 27, 124)
    };
    void Start()
    {
        int[] indicesUsed = new int[10];
        for (int i = 0; i < 9; i++)
        {
            int randIndex = Random.Range(0, 15);
            while (indicesUsed.Contains(randIndex))
            {
                randIndex = Random.Range(0, 15);

            }
            indicesUsed[i] = randIndex;
            GameObject currentTreasure = Instantiate(treasure);
            currentTreasure.transform.position = positions[randIndex];
            treasures[i] = currentTreasure;
        }

        lastTreasure = Instantiate(treasure);
        lastTreasure.transform.position = new Vector3(210, 1, 923);
        treasures[9] = lastTreasure;
        lastTreasure.SetActive(false);
    }

    void Update()
    {
        if (CountTreasures.treasuresFound == 9)
        {
            lastTreasure.SetActive(true);
        }
    }
}
