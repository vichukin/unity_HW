using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    SceneManager SceneManager;
    public int Scene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Run>())
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
