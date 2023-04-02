using System.Collections;
using System.Collections.Generic;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 180;
    public float hour = 1;
    public Text hourText;
    public Text timerText;
    public GameObject ogCanvas;
    public GameObject hourCanvas;
    public Text hourCanvasText;
    public AudioSource au1;
    public AudioSource au2;
    public AudioClip ac1;
    public AudioClip ac2;



    IEnumerator Hour()
    {
        hourCanvas.SetActive(true);
        ogCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        hourCanvas.SetActive(false);
        ogCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else 
        { 
            timeValue = 0;
            hour = hour + 1;
            StartCoroutine(Hour());
            timeValue = 180;
        }

        DisplayTime(timeValue);
        hourText.text = "HOUR " + hour.ToString();

        if (hour >= 10)
        {
            Debug.Log("Complete");
        }

        hourCanvasText.text = "HOUR " + hour.ToString();

        if (timeValue <= 3)
        {
            au1.PlayOneShot(ac1);
            au2.PlayOneShot(ac2);
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
