using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetWinResult : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = $"Coins:  {CoinCount.Coins}/9";
    }
}
