using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
     public void RestartGame()
    {
        SceneManager.LoadScene("InicioJuego3D");
    }

    public void Salir()
    {
        //detiene el modo ejecucion de unity
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("salir");
        //para simular que salimos del videojuego
        Application.Quit();
    }
}
