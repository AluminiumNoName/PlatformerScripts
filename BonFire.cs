using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonFire : MonoBehaviour
{
    public float burnTime = 15;
    public float increaseSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        burnTime -= Time.deltaTime;
        if (burnTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Temperature>() != null)
        {
            Temperature temp = other.GetComponent<Temperature>();
            if (temp.temperatureCurrent <= temp.normTemp)
            {
                temp.temperatureCurrent += increaseSpeed * Time.deltaTime;
            }
        }
    }
}
