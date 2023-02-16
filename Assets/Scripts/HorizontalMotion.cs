using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalMotion : MonoBehaviour
{

    void Start()
    {
        float moveTime = 1.5f / (Mathf.FloorToInt(Settings.duration / 20 + 1) * 0.5f);
        this.transform.DOMoveX(11, moveTime).SetEase(Ease.Linear).OnComplete(() => Destroy(this.gameObject));
    }
}
