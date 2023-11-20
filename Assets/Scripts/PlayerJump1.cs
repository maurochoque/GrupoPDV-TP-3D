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

        float jumpVelocity = Mathf.Sqrt(2f * jumpHeight * Mathf.Abs(Physics.gravity.y));
    GetComponent<Rigidbody>().AddForce(Vector3.up * jumpVelocity, ForceMode.VelocityChange);

        

    }

    bool CheckGrounded()
    {
        //metodo para verificar si el jugador esta en el suelo
        return Physics.Raycast(transform.position, Vector3.down, groundRaycastDistance);
        
    }
 
        
}
