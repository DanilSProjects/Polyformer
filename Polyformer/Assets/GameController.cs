using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float delay = 0.3f;
    
    public void loadNext() {
        Invoke("nextLevel", delay);
    }

    void nextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
