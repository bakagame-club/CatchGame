using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static int score;
    public static float duration;
    void Start()
    {

        DontDestroyOnLoad(this);

    }


    void Update()
    {
        Application.targetFrameRate = 60;
        duration += Time.deltaTime;
    }

    public static void Init()
    {
        score = 0;
        duration = 0;
    }
}
