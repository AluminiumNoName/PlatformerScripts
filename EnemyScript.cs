using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed; //variable for enemy speed
    public Transform target; //variable for enemys target
    public int damage = 2; //variable for enemy damage


    //void for movement
    void Update()
    {
        //������ ��������� ����� �� �����: ����������� ������� ���������, ��������� ����, ���������� ����� ���� 
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //�� � ������������� ����� �� ������
        transform.LookAt(target.position);
        
    }

    // ���������� ������������ 
    private void OnTriggerEnter(Collider other)
    {
        // Player - �������� �������, � ������� ���� ��������� 
        // ������� ������, ������ �� ����, ��� ���������� � ����������� � ������� ����
        Player thePlayer = other.GetComponent<Player>();
        if (thePlayer)
        {
            thePlayer.TakeDamage(damage);
        }
    }
    
       
    
}
