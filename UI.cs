using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //для Ui
using TMPro; // для текста
using Unity.VisualScripting;

public class UI : MonoBehaviour
{
    // следующие переменные определяются в Unity
    public Player player; // игрок
    public TextMeshProUGUI coinText; // текст количество монет
    public Slider healthSlider; // слайдер здоровья


    // Update is called once per frame
    void Update()
    {
        //здоровье
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;
        //монетки
        coinText.text = "Coins   " + player.coins.ToString();
    }
}
