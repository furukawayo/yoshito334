using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class display : MonoBehaviour
{

    [SerializeField] GameObject target;


    void Start()
    {
        Invoke("EndSceneGameObject", 30.1f);
    }

    public void EndSceneGameObject()
    {
        target.SetActive(true);
    }

}