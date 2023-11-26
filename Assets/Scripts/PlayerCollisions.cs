using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollisions : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("DefeatScene");
            Destroy(this.gameObject);
        }
        
        else if (collision.CompareTag("Wall"))
        {
            SceneManager.LoadScene("DefeatScene");
            Destroy(this.gameObject);
            
        }
    }

}
