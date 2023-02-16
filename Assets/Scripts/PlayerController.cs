using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PushSensing upButton;
    [SerializeField] private PushSensing bottomButton;
    [SerializeField] private int[] movePointY = new int[3];
    private int moveIndex;
    private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    void Start()
    {

        moveIndex = 2;

        audioSource = this.GetComponent<AudioSource>();
    }


    void Update()
    {

        if (upButton.isPushing)
        {
            if (moveIndex < movePointY.Length - 1) moveIndex++;
            this.transform.DOMoveY(movePointY[moveIndex], 0.2f);
            upButton.isPushing = false;
        }
        else if (bottomButton.isPushing)
        {
            if (moveIndex > 0) moveIndex--;
            this.transform.DOMoveY(movePointY[moveIndex], 0.2f);
            bottomButton.isPushing = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.IndexOf("Coin") >= 0)
        {
            Settings.score++;
            audioSource.time = 0;
            audioSource.PlayOneShot(clip);
        }

        if (other.name.IndexOf("Enemy") >= 0)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
