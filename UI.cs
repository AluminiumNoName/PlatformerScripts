using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //��� Ui
using TMPro; // ��� ������
using Unity.VisualScripting;

public class UI : MonoBehaviour
{
    // ��������� ���������� ������������ � Unity
    public Player player; // �����
    public TextMeshProUGUI coinText; // ����� ���������� �����
    public Slider healthSlider; // ������� ��������


    // Update is called once per frame
    void Update()
    {
        //��������
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;
        //�������
        coinText.text = "Coins   " + player.coins.ToString();
    }
}
