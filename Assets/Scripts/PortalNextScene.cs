
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalNextScene : MonoBehaviour
{
    public int Scene;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Run>())
        {
            CoinCount.AddCoin( collision.GetComponent<Run>().Coins);
            SceneManager.LoadScene(Scene);
        }
    }
}
