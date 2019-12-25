using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject eCanvas;
    public GameObject letterCanvas;
    public float delay = 0.3f;
    int eNo = 0;
    public bool isTouching = false;
    
    public void loadNext() {
        Invoke("nextLevel", delay);
    }

    void nextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void retry() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update() {
        if (eCanvas != null) {
            if (isTouching == true) {
                eCanvas.SetActive(true);
                if(Input.GetButtonDown("Interact")) {
                    eNo += 1;
                    if (eNo % 2 != 0) {
                        letterCanvas.SetActive(true);
                    } else {
                       letterCanvas.SetActive(false);
                    }
                 }
             } else {
            eCanvas.SetActive(false);
            }
        }
        
    }
}
