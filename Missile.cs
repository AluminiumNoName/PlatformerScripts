using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //allows missile to move forward, using it's speed
        transform.position += transform.forward * speed * Time.deltaTime;
    }
//allows destroy the OTHER game object along with the moving object itself
    private void OnTriggerEnter(Collider other)
    {
        EnemyScript theEnemy = other.GetComponent<EnemyScript>();
        Destroy(theEnemy.gameObject);
        Destroy(gameObject);
    }
}
