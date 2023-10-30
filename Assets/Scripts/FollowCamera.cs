using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    Transform Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = transform.position;
        vector.x = Player.position.x;
        vector.y = Player.position.y + 1;
        transform.position = vector;
    }
}
