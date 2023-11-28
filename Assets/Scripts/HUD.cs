using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class HUD : MonoBehaviour
{   

     public TextMeshProUGUI score;
    private float time = 40;

    void Update()
    {
        //del GameObject score (tipo TextMeshProUGUI) se cambia el text 
        // por el valor de time, ToString convierte el contenido de time en String con formato F0(Sin Decimal, redondea al numero entero mas cercano)
        score.text = time.ToString("F0");

        //imprime el tiempo actual en la consola de Unity. ToString convierte el valor de time en String, con formato F2(2 Decimales)
        Debug.Log("Tiempo restante: " + time.ToString("F2"));

        //reduce el tiempo restante en cada fotograma.
        time -= Time.deltaTime;

        //verifica si el tiempo ha llegado a cero o menos.
        if (time <= 0)
        {
            //llama a la funcion FinishGame si el tiempo se ha agotado.
            FinishGame();
        }
    }

    //carga la escena "Victory" al finalizar el juego (cuando el tiempo llega a cero).
    public void FinishGame()
    {
        SceneManager.LoadScene("VictoryScene");
    }
    
}

