using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonRestart : MonoBehaviour
{
     public void RestartGame()
    {
        SceneManager.LoadScene("InicioJueo3D");
    }
}
