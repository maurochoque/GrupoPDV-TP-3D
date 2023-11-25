    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float initTime = 0;
    [SerializeField] private float timeSpawner = 1;

    private float repeatTime;
    void Start()
    {
        repeatTime = Random.Range(3, 4*timeSpawner);
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }
    void Update()
    {
        repeatTime = Random.Range(3, 4);
    }
    public void GenerateEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
