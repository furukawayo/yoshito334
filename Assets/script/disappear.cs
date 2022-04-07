using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Hoge", 30);
    }

    // Update is called once per frame
    void Hoge()
    {
        this.gameObject.SetActive(false);
    }
}
