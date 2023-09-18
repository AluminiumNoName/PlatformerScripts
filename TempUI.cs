using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //��� Ui
using TMPro; // ��� ������
using Unity.VisualScripting;

public class TempUI : MonoBehaviour
{
    //���������� ����� ���������� � Unity
    // Temperature - �������� �������-����������, ������� ����� �����, temperature = ���������� ��� ������, ��� ��� �����?
    public Temperature temperature;
    public TextMeshProUGUI temperatureText;

    void Update()
    {
        //� ������� ��������� = ���������� �����, �� �������� = �������� �������
        float roundTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        temperatureText.text = roundTemperature.ToString();
    }

}

