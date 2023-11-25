using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpecial : MonoBehaviour
{
     public float detectionDistance = 10f; //disstancia de deteccion
    public float speed = 5f; //velocidad de persecucion
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //comienza la logica de persecucion
        StartCoroutine(HuntPlayer());
    }

    IEnumerator HuntPlayer()
    {
        while (true)
        {
            //calcula la distancia entre el enemySpecial y el player
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            //si el player está dentro de la distancia de deteccion
            if (distanceToPlayer <= detectionDistance)
            {
                //para perseguir al player
                transform.LookAt(player);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                //para ver en la pantalla de prueba el rayo (raycast)
                Debug.DrawRay(transform.position, transform.forward * detectionDistance, Color.red);

            }

            //espera un breve tiempo antes de volver a verificar
            yield return new WaitForSeconds(0.1f);
        }
    }
}
