using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Speed = 1;
    public static int Coins = 0;
    public static void AddCoin(int coin)
    {
            var text = GameObject.FindGameObjectsWithTag("CoinCounter").First().GetComponent<Text>();
            CoinCount.Coins+=coin;
            text.text ="Coins: "+ CoinCount.Coins.ToString();
    }
    public static void AddSpeed()
    {
        if(Speed<5)
        {
            var text = GameObject.FindGameObjectsWithTag("SpeedCounter").First().GetComponent<Text>();
            CoinCount.Speed++;
            text.text = CoinCount.Speed.ToString();
        }
    }
    public static void RemoveSpeed()
    {
        if (Speed > 1)
        {
            var text = GameObject.FindGameObjectsWithTag("SpeedCounter").First().GetComponent<Text>();
            CoinCount.Speed--;
            text.text = CoinCount.Speed.ToString();
        }
    }
}
