using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class find : MonoBehaviour
{
    public TextMeshProUGUI cubeCountText;
    private Vector3 mousePosition;
    private int count;
    public GameObject[] prefabArray;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count = Random.Range(0, prefabArray.Length);
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            Instantiate(prefabArray[count], Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
        }

        GameObject[] GameObjects = GameObject.FindGameObjectsWithTag("Game");

        cubeCountText.text = "enemy:" + GameObjects.Length.ToString();
    }
}