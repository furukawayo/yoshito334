using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    private GameObject[] BlockObjects;

    void Update()
    {
        BlockObjects = GameObject.FindGameObjectsWithTag("Game");

        if (BlockObjects.Length == 0)
        {
            SceneManager.LoadScene("ccc");
        }
    }
}