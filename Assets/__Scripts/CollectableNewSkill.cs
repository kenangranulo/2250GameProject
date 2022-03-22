<<<<<<< Updated upstream
using System.Collections;
=======
﻿using System.Collections;
>>>>>>> Stashed changes
using System.Collections.Generic;
using UnityEngine;

public class CollectableNewSkill : MonoBehaviour {

<<<<<<< Updated upstream
    // Update is called once per frame
    void Update() {
=======


    // Update is called once per frame
    void Update() {

>>>>>>> Stashed changes
        if (Input.GetKeyDown(KeyCode.Tab)) {
            DestroyAll();
        }
    }
<<<<<<< Updated upstream

    //activates the script
    public void Activate() {
        this.enabled = true;
    }

=======
    //activates the script
    public void Activate() {

        this.enabled = true;
    }
>>>>>>> Stashed changes
    //destroys all the enemies on the screen
    void DestroyAll() {

        //insert code to destroy all the enemies on screen

        this.enabled = false;
    }
}
