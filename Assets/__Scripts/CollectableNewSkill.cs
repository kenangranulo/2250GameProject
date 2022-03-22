using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableNewSkill : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            DestroyAll();
        }
    }

    //activates the script
    public void Activate() {
        this.enabled = true;
    }

    //destroys all the enemies on the screen
    void DestroyAll() {

        //insert code to destroy all the enemies on screen

        this.enabled = false;
    }
}
