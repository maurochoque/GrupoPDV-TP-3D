using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemyMoveZ : MonoBehaviour
{
   public float speedXenemy = 5f;
    Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        //inicia el movimiento hacia la derecha
        MoveRight();
    }

    void MoveRight()
    {

        rb.velocity = new Vector3(0, 0, speedXenemy);

        //llama a MoveLeft despues de 4 segundos
        Invoke("MoveLeft", 2.5f);
    }

    void MoveLeft()
    {
        //mueve hacia la izquierda
        transform.Translate(Vector3.up * speedXenemy * Time.deltaTime);

        //llaama a MoveRight despues de 4 segundos
        Invoke("MoveRight", 2.5f);
        //cambia el valor de speedXenemy al contrario para cambio de direccion
        speedXenemy*=-1;
    }
}
