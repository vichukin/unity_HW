using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GetCurrentSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("SpeedCounter").First().GetComponent<Text>().text=CoinCount.Speed.ToString();
    }
}
