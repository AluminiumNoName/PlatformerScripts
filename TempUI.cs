using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //для Ui
using TMPro; // для текста
using Unity.VisualScripting;

public class TempUI : MonoBehaviour
{
    //переменные нужно определить в Unity
    // Temperature - название скрипта-компонента, который нужно найти, temperature = переменная для ссылки, где его найти?
    public Temperature temperature;
    public TextMeshProUGUI temperatureText;

    void Update()
    {
        //в скобках множитель = количество целых, за скобками = смещение запятой
        float roundTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        temperatureText.text = roundTemperature.ToString();
    }

}

