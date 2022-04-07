using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text1 : MonoBehaviour
{
    private static GameObject[] enemyBox;
    //ゲーム起動時に呼び出される
    void Start()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("Game");
        print("残った数：" + enemyBox.Length);
    }
}