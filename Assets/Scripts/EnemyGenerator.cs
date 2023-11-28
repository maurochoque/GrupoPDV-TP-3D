    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //para instanciar un GameObject desde el inspector (un prefabs)
    [SerializeField] private GameObject enemy;
    //instanciamos desde inspector (unity) con el valor deseado
    [SerializeField] private float initTime = 0;
    [SerializeField] private float timeSpawner = 1;

    private float repeatTime;
    void Start()
    {
        //contiene un valor entre 3 y 4 (incluso 3 y 4) multiplicado por timeSpawner
        repeatTime = Random.Range(3, 4)*timeSpawner;
        //llama al metodo GenerateEnemy, initTime indica cuando empezara, repeatTime indica cada cuanto se debe llamar al metodo GenerateEnemy
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }
    void Update()
    {
        //continuamente se obtiene numeros entre 3 y 4 (incluso 3 y 4)
        repeatTime = Random.Range(3, 4);
    }
    public void GenerateEnemy()
    {
        //crea el GameObject(prefabs enemy) desde la posicion de este GameObject y su rotacion
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
