using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �������� �� �����, ��������� �������� � ���������


public class Player : MonoBehaviour
{
    //�������� ������
    public int health = 10;
    public int maxHealth = 10;
   
    //� ������ ��� �������
    public int coins;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    //�������������
    public AudioSource audioSource;

    //�������� �������
    public AudioClip damageSound;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //��������� ������ ��������, ������ ���, ��� ����� ������ � ������������ �������������� ����� ������
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Health" + health);

        if (health > 0) //���� �������� ������ 0 ����������� ���� ����� � ����
        {
            audioSource.PlayOneShot(damageSound);
        
        }
       
        else // � ��������� ������� (>=0) ������������� ������� �����
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex; // ������� ������� �����
            SceneManager.LoadScene(sceneIndex); // ��������� ����� ������
        }

    }

}
