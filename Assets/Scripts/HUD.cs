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
        score.text = time.ToString("F0");
        time = time - 1 * Time.deltaTime;
        if(time <= 0)
        {
            FinishGame();
        }
    }

    public void FinishGame()
    {
        SceneManager.LoadScene("Victory");
    }
}
