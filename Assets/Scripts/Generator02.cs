using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator02 : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy02;
    [SerializeField]
    private float speedGeneratorZ = 3;
    // Start is called before the first frame update
    void Start()
    {
            Invoke("GenerateEnemy2", 2);
            Invoke("GenerateEnemy2", 4);
            Invoke("GenerateEnemy2", 6);
            Invoke("GenerateEnemy2", 8);
            Invoke("GenerateEnemy2", 10);
    }

    // Update is called once per frame
    void Update()
    {
        MoveGenerator();
    }

    public void GenerateEnemy2()
    {
        Instantiate(enemy02, transform.position, transform.rotation);
    }
    public void MoveGenerator()
    {
        transform.Translate(0, 0, speedGeneratorZ * Time.deltaTime);
        if (transform.position.z > 5f || transform.position.z < -5f)
        {
            speedGeneratorZ *= -1;
        }
        
    }
}
