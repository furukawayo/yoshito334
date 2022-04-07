using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class display1 : MonoBehaviour
{

    [SerializeField] GameObject target;


    void Start()
    {
        Invoke("EndSceneGameObject", 30f);
    }

    public void EndSceneGameObject()
    {
        target.SetActive(true);
    }

}