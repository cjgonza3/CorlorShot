using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyAngle;
    public Transform enemyStraight;
    public float x = 7.64f;

    void EnemySpawnAngle()
    {
        var a = Instantiate(enemyAngle, new Vector2(x, Random.Range(-4.5f, 4.5f)), Quaternion.identity);
        a.transform.parent = GameObject.Find("GameElements").transform;
    }

    void EnemySpawnStraight()
    {
        var ab = Instantiate(enemyStraight, new Vector2(x, Random.Range(-4.5f, 4.5f)), Quaternion.identity);
        ab.transform.parent = GameObject.Find("GameElements").transform;
    }

    void SpawnLine(float yaxis, int counter)
    {
        if (counter < 5)
        {
            Instantiate(enemyStraight, new Vector2(x, yaxis), Quaternion.identity);
            counter++;
        }
    }

    void EnemySpawnLine()
    {
        float temp_x = 3;
        float temp_y = Random.Range(-4.5f, 4.5f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemyStraight, new Vector2(temp_x + i*10, temp_y), Quaternion.identity);
        }
    }

    void Start()
    {
        InvokeRepeating("EnemySpawnAngle", time: Random.Range(1f, 3f), repeatRate: Random.Range(1f, 5f));
        InvokeRepeating("EnemySpawnStraight", time: Random.Range(1f, 3f), repeatRate: Random.Range(1f, 5f));
        //InvokeRepeating("EnemySpawnLine", time: 5.3f, repeatRate: 8.32f);
    }


}


