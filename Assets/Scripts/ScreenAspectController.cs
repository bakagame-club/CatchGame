using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAspectController : MonoBehaviour
{
    private float defaultOthgraphSize;

    void Start()
    {
        Application.targetFrameRate = 60;
        defaultOthgraphSize = Camera.main.orthographicSize;
        float defaultAspectRatio = 16.0f / 9.0f;
        float displayAspectRatio = (float)Screen.width / (float)Screen.height;
        Camera.main.orthographicSize = defaultOthgraphSize * (defaultAspectRatio / displayAspectRatio);
    }


    void Update()
    {

        float defaultAspectRatio = 16.0f / 9.0f;
        float displayAspectRatio = (float)Screen.width / (float)Screen.height;
        Camera.main.orthographicSize = defaultOthgraphSize * (defaultAspectRatio / displayAspectRatio);



    }
}
