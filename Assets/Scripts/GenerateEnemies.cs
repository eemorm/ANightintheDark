using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount = 1;
    public TextMeshProUGUI enemyText;
    void Start()
    {
        StartCoroutine(EnemyDrop());
        
    }

    IEnumerator EnemyDrop()
    {
        while(enemyCount < 100)
        {
            xPos = Random.Range(-40, 40);
            zPos = Random.Range(-100, -23);
            Instantiate(theEnemy, new Vector3(xPos, 8, zPos), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
            enemyCount += 1;
        }
    }

    public void FixedUpdate()
    {
        enemyText.text = "Enemies Spawned: " + (enemyCount + 1).ToString();
    }
}
