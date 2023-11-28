using System.Collections;
using TreeEditor;
using UnityEngine;

public class SpawnerPatrolCube : MonoBehaviour
{
     public float patrolSpeed = 5f; //velocidad de patrullaje
    public float patrolDuration = 1f; //duracion de cada patrullaje en una direccio
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;

        //inicia la rutina de patrullaje
        StartCoroutine(PatrolCorrutine());
    }

    IEnumerator PatrolCorrutine()
    {
        while (true)
        {
            //se mueve sobre el eje X a las coordenadas del nuevo Vector
            yield return StartCoroutine(MoveInDirection(new Vector3(23,0,0), patrolDuration));
            //para que se ejecute apenas empiece el programa
            yield return null;


            //se mueve sobre el eje Z a las coordenadas del nuevo Vector
            yield return StartCoroutine(MoveInDirection(new Vector3(23,0,24), patrolDuration));

            //se mueve sobre el eje X a las coordenadas del nuevo Vector
            yield return StartCoroutine(MoveInDirection(new Vector3(0,0,24), patrolDuration));

            //se mueve sobre el eje Z a las coordenadas del nuevo Vector
            yield return StartCoroutine(MoveInDirection(new Vector3(0,0,0), patrolDuration));
        }
    }
    

    IEnumerator MoveInDirection(Vector3 direction, float duration)
    {
        //para controlar el bucle y controlar que la corrutina pase a otra etapa en PatrolCorrutine
        float controlTime = 0f;
        
        //un Vector que tendra la suma de transform.position(de este GameObject)
        // y direction (Vector que se recibe por parametro) al llamar esta corrutina
        // dentro de otra corrutina PatrolCorrutine
        Vector3 targetPosition = initialPosition + direction;

        //condicional, cuando deje de cumplirse pasara al siguiente yield return en PatrolCorrutine
        while (controlTime < duration)
        {   
            //simplificado, movera el GameObject que tenga este scrip desde su transform.position
            //hacia targetPosition a una velocidad de patrolSpeed * Time.deltaTime
            transform.position = Vector3.Lerp(transform.position, targetPosition, patrolSpeed * Time.deltaTime);
            //aumenta en cada vuelta del bucle, para que en algun momento deje de cumplirse el while
            controlTime += Time.deltaTime;
            //para realizar una pequeña en la ejecucion de esta corrutina, hasta el siguiente frame
            yield return null;
        }
    }
    
}
