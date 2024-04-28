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
        //мен€ем положение ≈неми на новое: высчитываем “екущее положение, положение ÷ели, –ассто€ние между ними 
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //ну и разворачиваем ≈неми на игрока
        transform.LookAt(target.position);
        
    }

    // определ€ем столкновение 
    private void OnTriggerEnter(Collider other)
    {
        // Player - название скрипта, в котором ищем компонент 
        // находим игрока, исход€ из того, кто столкнулс€ с коллайдером и наносим урон
        Player thePlayer = other.GetComponent<Player>();
        if (thePlayer)
        {
            thePlayer.TakeDamage(damage);
        }
    }
    
       
    
}
