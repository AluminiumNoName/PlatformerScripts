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
        seconds -= Time.deltaTime; // вычитаем кадр (~секунда)

        if (seconds <= 0) // если секунд осталось меньше или равно 0
        {
            if (minutes > 0) // если минут больше 0
            {
                seconds += 59; // секунды +59 (обновление отсчета)

                minutes--;
            }
            else
            { 
                // ≈сли таймер остановилс€(минут меньше или равно 0), перезагружаем текущую сцену
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }

        int roundSeconds = Mathf.RoundToInt(seconds); // округл€ем при помощи спецсервиса
        timerText.text = minutes + ":" + roundSeconds; //  записываем в тексте

    }
}
