using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovementZ : MonoBehaviour
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
        transform.Translate(0, 0, enemyDirection * Time.deltaTime * speedXenemy);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
