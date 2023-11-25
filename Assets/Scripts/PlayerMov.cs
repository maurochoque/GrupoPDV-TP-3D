using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
   
   public float movementSpeed = 8.0f;

    void Update()
    {
        //obtener entrada de teclado para el movimiento
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //calcular la direccion del movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        //mover el jugador en la direccion calculada
        transform.Translate(movement * movementSpeed * Time.deltaTime);
    }
    
}
