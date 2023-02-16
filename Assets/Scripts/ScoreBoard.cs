using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private Text scoreBoard;
    [SerializeField] private string pointName;

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "SampleScene")
        {
            if (pointName.Length > 0) scoreBoard.text = pointName + ": " + Settings.score.ToString();
            else scoreBoard.text = Settings.score.ToString();
        }
        else
        {
            scoreBoard.text = Settings.score.ToString();
        }
    }
}
