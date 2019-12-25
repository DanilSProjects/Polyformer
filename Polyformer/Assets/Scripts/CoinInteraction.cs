using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInteraction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.name == "Player") {

            PlayerMovement.coins += 1;
            Debug.Log(PlayerMovement.coins);
            Destroy(gameObject);
        }
    }
}
