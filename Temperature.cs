using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float temperatureCurrent = 36.6f;
    public float normTemp = 36.6f;
    public float critTemp = 34;
    public float decreaseSpeed = 0.05f;
    public int damage = 2;
    public Health health;

    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

  

    // Update is called once per frame
    void Update()
    {
        temperatureCurrent -= decreaseSpeed*Time.deltaTime;  //если не домножить будет слишком быстро сменяться

        if (temperatureCurrent <= critTemp)
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(damage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        } 
    }
}
