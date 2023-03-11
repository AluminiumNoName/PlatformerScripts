using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime; // �������� ���� (~�������)

        if (seconds <= 0) // ���� ������ �������� ������ ��� ����� 0
        {
            if (minutes > 0) // ���� ����� ������ 0
            {
                seconds += 59; // ������� +59 (���������� �������)

                minutes--;
            }
            else
            { 
                // ���� ������ �����������(����� ������ ��� ����� 0), ������������� ������� �����
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }

        int roundSeconds = Mathf.RoundToInt(seconds); // ��������� ��� ������ �����������
        timerText.text = minutes + ":" + roundSeconds; //  ���������� � ������

    }
}
