using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class cube : MonoBehaviour
{
    private float time;
    private float vecX;
    private float vecZ;
 
    void Update()
    {
        time -= Time.deltaTime;
 
        if(time <= 0)
        {
           vecX = Random.Range(-4.5f, 5.0f);
           vecZ = Random.Range(-4.5f, 5.0f);
           this.transform.position = new Vector3(vecX, 0.5f, vecZ);
           time = 2.0f;
        }
    }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "ccc")
            {
                Destroy(gameObject, 0.2f);
            }
        }
}