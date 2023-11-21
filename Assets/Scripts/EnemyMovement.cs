using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    [SerializeField]
    private int enemyDirection; // 1 o -1
    [SerializeField]
    private float speedXenemy = 3f;

    void Update()
    {
        MoveEnemy();
    }
    public void MoveEnemy()
    {
        transform.Translate(enemyDirection * Time.deltaTime * speedXenemy, 0, 0);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
