using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Gameplay Instance;

    [Header("Variable")]
    public int gold = 0;

    private void Awake()
    {
        Instance = this;
    }
}
