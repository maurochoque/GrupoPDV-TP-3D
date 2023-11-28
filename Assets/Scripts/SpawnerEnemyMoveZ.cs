using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemyMoveZ : MonoBehaviour
{
   public float speedZenemy = 5f;
    Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        //inicia el movimiento hacia la derecha
        MoveUp();
    }

    void MoveUp()
    {
        //primero se mueve en el eje Z aumentando
        rb.velocity = new Vector3(0, 0, speedZenemy);

        //llama a MoveBot despues de 2 segundos
        Invoke("MoveBot", 2.5f);
    }

    void MoveBot()
    {
        //mueve en el eje Z aumentando(hacia adelante)
        //transform.Translate(Vector3.forward * speedZenemy * Time.deltaTime);
        
        //llaama a MoveRight despues de 2 segundos
        Invoke("MoveUp", 2.5f);
        //cambia el valor de speedXenemy al contrario para cambio de direccion
        speedZenemy*=-1;
    }
}
