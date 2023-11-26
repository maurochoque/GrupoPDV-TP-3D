using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemyMovX : MonoBehaviour
{
    public float speedXenemy = 5f;
    Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        MoveRight();
    }

    void MoveRight()
    {

        rb.velocity = new Vector3(speedXenemy, 0, 0);

        //llama a MoveLeft despues de 3 segundos
        Invoke("MoveLeft", 3f);
    }

    void MoveLeft()
    {
        //mueve hacia la izquierda
        transform.Translate(Vector3.left * speedXenemy * Time.deltaTime);

        //llaama a MoveRight despues de 3 segundos
        Invoke("MoveRight", 3f);
        //cambia el valor de speedXenemy al contrario para cambio de direccion
        speedXenemy*=-1;
    }
    
}

