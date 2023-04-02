using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSewers : MonoBehaviour
{
    public void MoveToSewers()
    {
        SceneManager.LoadScene("Sewers");
    }

}
