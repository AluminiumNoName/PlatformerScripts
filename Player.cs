using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // отвечает за сцены, позволяет находить и загружать


public class Player : MonoBehaviour
{
    //здоровье игрока
    public int health = 10;
    public int maxHealth = 10;
   
    //в скрипт для монеток
    public int coins;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    //проигрыватель
    public AudioSource audioSource;

    //Звуковой образец
    public AudioClip damageSound;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //клонируем префаб фаербола, ставим там, где точка вылета и поворачиваем соответственно точке вылета
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Health" + health);

        if (health > 0) //если здоровья больше 0 проигрываем звук удара и боли
        {
            audioSource.PlayOneShot(damageSound);
        
        }
       
        else // в остальных случаях (>=0) перезагружаем текущую сцену
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex; // находим текущую сцену
            SceneManager.LoadScene(sceneIndex); // загружаем сцену заново
        }

    }

}
