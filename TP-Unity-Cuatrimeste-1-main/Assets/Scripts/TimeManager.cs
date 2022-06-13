using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTiempoFloored;
    public Text txtCuentaRegresiva;
    public GameObject txtCount;

    public float TimeToChange;
    public float waitTime;
    public bool TerminoCountDown;
    int counter;

    void Start()
    {
        counter = 3;
        txtCuentaRegresiva.text = counter.ToString();
        TerminoCountDown = false;
    }

    void Update()
    {
        txtTime.text = Time.time.ToString();
        txtTiempoFloored.text = Mathf.FloorToInt(Time.time).ToString();

        if (TimeToChange < Time.time)
        {
            counter--;
            if (counter > 0)
            {
                txtCuentaRegresiva.text = counter.ToString();
                TimeToChange += waitTime;
            }
            else if (counter < 0 && counter > -1.2f)
            {
                txtCuentaRegresiva.text = "GO!";
            }
        }

        if (Time.time > 6)
        {
            txtCount.SetActive(false);
            TerminoCountDown = true;
        }
    }
}