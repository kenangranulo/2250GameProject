using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start() {

        currentHealth = maxHealth;
    }

    //method for the enemy to take damage
    public void TakeDamage(int damage) {
        currentHealth -= damage;

        if (currentHealth <= 0) {
            Die();
        }
    }

    //method for the enemy to die
    void Die() {

        //make the enemy dead animation

        GetComponent<Collider2D>().enabled = false;
        Destroy(this.gameObject);
    }
}