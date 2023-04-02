using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectCharge : MonoBehaviour
{
    private int count;
    private int wincount;
    public TextMeshProUGUI countText;

    void Start()
    {
        count = 0;

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Charges: " + count.ToString();
        if(count >= 5)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Backround11");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

    }
}
