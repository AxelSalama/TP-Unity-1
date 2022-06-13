using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeManager : MonoBehaviour
{
    public Text txtTimeFloored;
    public Text txtCountdown;
    int counter;
    public float timeToChange;
    public float waitTime;
    public Text txtTiempoFinal;

    float tiempo = 0;
    float countertiempo = -6;

    void Start()
    {
        counter = 3;
        txtCountdown.text = counter.ToString();

        txtTiempoFinal = txtTimeFloored;
    }
    void Update()
    {
        countertiempo = Time.time;

        if(Time.time -6 >= 0)
        {
         txtTimeFloored.text = Mathf.FloorToInt(countertiempo - 6).ToString();
        }

        if(Time.time >= tiempo + 6)
        {

        } 

        if (timeToChange < Time.time)
        {
            counter--;
                if (counter > 0)
                {
                    txtCountdown.text = counter.ToString();
                    timeToChange += waitTime;
                }
                else
                {
                txtCountdown.text = "¡Start!";
                }

            if (counter <= 7)
            {
                Destroy(txtCountdown);
            }
        }
    }
}
