using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameController gc;
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

    void FixedUpdate() {
        // Move our character
         controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
         jump = false;
    }
    public void onLanding() {
        // land
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag) {

            case "NextLvl":
            gc.loadNext();
            break;

            case "Death":
            gc.retry();
            break;

            case "Letter":
            gc.isTouching = true;
            break;

            default:
            break;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        switch (other.tag) {
            case "Letter":
            gc.isTouching = false;
            break;

            default:
            break;
        }
    }

}
