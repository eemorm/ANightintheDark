using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{

    public GameObject Eye1;
    public GameObject Eye2;
    private static bool done = false;
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(EyesMove());
    }

    IEnumerator EyesMove()
    {
        yield return new WaitForSeconds(3f);
        Eye1.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        Eye2.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        Eye1.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        Eye2.SetActive(true);
        done = true;
    }

    void Update() 
    {
        if (done)
        {
            done = false;
            StartCoroutine(EyesMove());
        }
        
    }
}
