using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
        {
            Cursor.visible = true;           
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("DeathScreen");
        }
    }
}
