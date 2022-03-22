using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int maxHealth = 100;
    int currentHealth;
    public GameObject hero;

    // Start is called before the first frame update
    void Start() {

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update() {

        transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, .003f);
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
        this.enabled = false;
    }
}