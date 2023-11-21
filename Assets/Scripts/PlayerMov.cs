using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Defeat");
            Destroy(this.gameObject);
        }
        else if (collision.CompareTag("Wall"))
        {
            SceneManager.LoadScene("Defeat");
            Destroy(this.gameObject);
        }
    }
}
