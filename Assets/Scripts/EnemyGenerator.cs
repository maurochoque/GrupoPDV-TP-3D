using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private float initTime = 2;
    private float repeatTime;
    void Start()
    {
        repeatTime = Random.Range(3, 10);
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }
    void Update()
    {
        repeatTime = Random.Range(3, 10);
    }
    public void GenerateEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
