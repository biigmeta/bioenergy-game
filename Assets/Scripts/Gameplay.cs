using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Gameplay Instance;

    [Header("Script Components")]
    public PlayerData playerData;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
