using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class next : MonoBehaviour
{
    private GameObject[] BlockObjects;
    [SerializeField] GameObject target;
    [SerializeField] GameObject target2;

    void Update()
    {
        BlockObjects = GameObject.FindGameObjectsWithTag("Game");

        if (BlockObjects.Length == 0)
        {
            target.SetActive(true);
            target2.SetActive(false);
        }
    }
}