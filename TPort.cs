using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TPort : MonoBehaviour
{
    public Transform tPoint;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = tPoint.position;
        }
      

    }

}
