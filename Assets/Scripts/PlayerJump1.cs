using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump1 : MonoBehaviour
{
      public float jumpHeight = 6.0f;
    public float groundRaycastDistance = 2.0f;
    private bool isGrounded;

    void Update()
    {
        //evita que el gameobject con este script, tenga rotacion
        transform.rotation = Quaternion.identity;
        //verificar si el jugador esta en el suelo
        isGrounded = CheckGrounded();

        //maneja el salto
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
            
        }
    }

    void Jump()
    {
        //en jumpVelocity se guarda la raiz cuadrada de todo el parentesis(formula)
        //  formula basada en ecuacion de la energiaa potencial gravitacional E p = m * g * h //m = masa , g = gravedad , h = altura
        //2f    conversion energia potencial a cinetica en un salto vertical
        //jumpHeight    altura de salto deseada
        //Mathf.Abs(Physics.gravity.y)  magnitud de la gravedad en el eje Y // Mathf.Abs para que el valor entre () sea siempre tratado como un valor +
        float jumpVelocity = Mathf.Sqrt(2f * jumpHeight * Mathf.Abs(Physics.gravity.y));

        //al GameObject con este script(con Rigidbody), le agrega una fuerza hacia arriba (en eje Y) multiplicado por el calculo anterior
        // ForceMode.VelocityChange     es el modo de fuerza aplicada, VelocityChange indica que es una fuerza aplicada es una velocidad instantanea y
        // cambia directo la velocidad del objeto
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpVelocity, ForceMode.VelocityChange);

        

    }

    bool CheckGrounded()
    {
        //metodo para verificar si el jugador esta en el suelo
        // retorna true o false, 1er parametro es la posicion del GameObject con este script
        // 2do parametro es un vector hacia abajo (en eje Y), 3er parametro es un rayo con una distancia de groundRaycastDistance (2f)
        // del GameObject se dispara un rayo que verifica, que este chocando con algo (el piso) o su distancia de choque sea menor a groundRaycastDistance
        return Physics.Raycast(transform.position, Vector3.down, groundRaycastDistance);
        
    }
 
        
}
