using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpecial : MonoBehaviour
{
    //disstancia de deteccion
     public float detectionDistance = 10f;
    //velocidad de persecucion
    public float speed = 5f; 
    //referencia al componente Transform de otro GameObject
    private Transform player;

    void Start()
    {
        //en player guardamos el transform de un GameObject con el Tag(etiqueta) Player
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //comienza la logica de persecucion
        StartCoroutine(HuntPlayer());
    }

    IEnumerator HuntPlayer()
    {
        while (true)
        {
            //calcula la distancia entre el EnemySpecial(que tiene este script) y el player
            float distancePlayer = Vector3.Distance(transform.position, player.position);

            //si el player esta dentro de la distancia de deteccion
            if (distancePlayer <= detectionDistance)
            {
                //el GameObject que tiene este script sigue/mira (pero NO se mueve) al GameObject que se pasa por parametro
                transform.LookAt(player);
                //una vez que se ubica la posicion del player, EnemySpecial(que tiene este script) se movera
                // hacia adelanta(a la posicion de player) persiguiendo al player, * speed * Time.deltaTime para fluidez independiente de los FPS
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                //para ver en la pantalla de prueba el rayo (raycast)
                Debug.DrawRay(transform.position, transform.forward * detectionDistance, Color.red);

            }

            //espera un breve tiempo antes de volver a verificar
            yield return new WaitForSeconds(0.1f);
        }
    }
}
