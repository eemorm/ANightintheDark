using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    IEnumerator DropPlayer()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    private void Start()
    {
        StartCoroutine(DropPlayer()); 
    }
}
