using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //variable declarations
    [SerializeField] float speed = 3;
    float teleportCooldown, invincibilityCooldown, healthResetCooldown, damageBoostCooldown;
    float playerhealth, playerHealthBeforeInvincibility;
    float playerDamage;
    public Animator animator;
    public SpriteRenderer spriteRenderer;


    // Awake is called when the script instance is being loaded
    void Awake() {
        playerhealth = 100;
        playerDamage = 5;
    }

    // Update is called once per frame
    void Update(){
        //variable declaration
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
      
        if(horizontal!=0||vertical!=0){
            animator.SetFloat("Speed",1);
        }else{
            animator.SetFloat("Speed",0);
        }

        if(horizontal<0){
            spriteRenderer.flipX=true;
        }
        if(horizontal>0){
            spriteRenderer.flipX=false;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }
        //moves the player
        Move(horizontal, vertical);

        //code used for player teleporting
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            Teleport(horizontal, vertical);
        }

        //code used for invincibility
        if (Input.GetKeyDown(KeyCode.E)) {
            playerHealthBeforeInvincibility = playerhealth;
            Invincibility();
        }

        //code used for activating a damage boost
        if (Input.GetKeyDown(KeyCode.Q)) {
            DamageBoost();
        }

        //after 30 seconds invincibility ends
        if (healthResetCooldown <= 0) {
            HealthReset(playerHealthBeforeInvincibility);
        }

        //cooldown handling
        teleportCooldown -= Time.deltaTime;
        invincibilityCooldown -= Time.deltaTime;
        healthResetCooldown -= Time.deltaTime;
        damageBoostCooldown -= Time.deltaTime;


    }

    //movement method
    void Move(float horizontal, float vertical) {
        //change the position of the player
        transform.position = transform.position + new Vector3(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);
    }

    void Attack(){
        animator.SetTrigger("Attack");
    }


    //teleport method
    void Teleport(float horizontal, float vertical) {
        //teleports the player if the cooldown is gone
        if (teleportCooldown <= 0) {
            teleportCooldown = 10;
            transform.position = transform.position + new Vector3(horizontal * 20f, vertical * 20f, 0f);
        }
    }

    //invincibility method
    void Invincibility() {
        if (invincibilityCooldown <= 0) {
            //sets the invincibility cooldown to 3 minutes and makes the player invincible, after 30 seconds invincibility will end
            healthResetCooldown = 30;
            invincibilityCooldown = 180;
            playerhealth = 10000;
        }
    }

    //resets health after invincibility ends
    void HealthReset(float health) {
       //resets the player's health to before invincibility, and then sets the cooldown to infinity 
       playerhealth = health;
       healthResetCooldown = 1000000;
    }

    //damage boost method
    void DamageBoost() {
        if (damageBoostCooldown <= 0) {
            //sets to cooldown to 2 minutes, doubles the players damage and after 15 seconds removes the damage boost
            damageBoostCooldown = 120;
            playerDamage = playerDamage * 2;
            Invoke("DamageReset", 15f);
        }
    }

    //resets the player's damage
    void DamageReset() {
        playerDamage = 5;
    }
}