using System;
using System.IO;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureManager : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject enemy;
    private float duration;
    [SerializeField] private int[] bornY;

    void Start()
    {
        InvokeRepeating("BornCreature", 1, 1);
    }


    private void BornCreature()
    {
        int maxParam = 3 + Mathf.FloorToInt(Settings.duration) / 10;
        int prob = UnityEngine.Random.Range(0, maxParam);

        int index = UnityEngine.Random.Range(0, bornY.Length);
        int y = bornY[index];

        if (prob < 2)
        {
            Instantiate(coin, new Vector3(-11, y, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(enemy, new Vector3(-11, y, 0), Quaternion.identity);
        }
    }
}
