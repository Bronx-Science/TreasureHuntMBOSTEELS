using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class JumpPad : MonoBehaviour
{
    void OnDestroy()
    {
        PadOnClick.countPads--;
    }
}
