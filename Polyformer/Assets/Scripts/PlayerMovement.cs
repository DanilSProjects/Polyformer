using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameController gc;
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public static int coins = 0;
    public bool canMove = true;
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump") && canMove == true) {
            jump = true;
        }
    }

    void FixedUpdate() {
        // Move our character
        if (canMove == true) {
             rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
             controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
             jump = false;
        } else {
            rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }
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
