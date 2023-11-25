using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator01 : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy01;
    [SerializeField]
    private float initTime = 0;
    [SerializeField]
    private float repeatTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }

    public void GenerateEnemy()
    {
        Instantiate(enemy01, transform.position, transform.rotation);
    }
}
