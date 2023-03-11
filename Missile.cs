using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //постоянно пересчитываем скорость снаряда. По умолчанию она равна 0
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyScript theEnemy = other.GetComponent<EnemyScript>();
        Destroy(theEnemy.gameObject);
        Destroy(gameObject);
    }
}
