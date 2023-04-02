using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 1f;

    public void DeductHealth(float deductHealth)
    {
        playerHealth -= deductHealth;
        if (playerHealth <= 0) { PlayerDead(); }
    }

    void PlayerDead()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("DeathScreen");
        }
    }
}