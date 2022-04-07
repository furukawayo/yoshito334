using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class text : MonoBehaviour
{
    private GameObject[] enemyBox;
 
    void Update()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("Game");
 
        print("プレイ中　残りの数：" + enemyBox.Length);
    }
}