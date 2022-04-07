using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class cube1 : MonoBehaviour
{
    private float chargeTime = 5.0f;
    private float timeCount;
 
    void Update()
    {
        timeCount += Time.deltaTime;
 
        transform.position += transform.forward * Time.deltaTime;
 
        if(timeCount > chargeTime)
        {

            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);
            timeCount = 0;
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