using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyScript : MonoBehaviour {

<<<<<<< Updated upstream
public class EnemyScript : MonoBehaviour {

    public int maxHealth = 100;
    int currentHealth;


=======
    public int maxHealth = 100;
    int currentHealth;
>>>>>>> Stashed changes
    public GameObject hero;

    // Start is called before the first frame update
    void Start() {
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update() {
<<<<<<< Updated upstream
        transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, .003f);
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;

=======

        transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, .003f);
    }

    //method for the enemy to take damage
    public void TakeDamage(int damage) {
        currentHealth -= damage;

        //do damage taken animation

>>>>>>> Stashed changes
        if (currentHealth <= 0) {
            Die();
        }
    }

<<<<<<< Updated upstream
=======
    //method for the enemy to die
>>>>>>> Stashed changes
    void Die() {

        //make the enemy dead animation

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
