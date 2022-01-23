using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Vector2 _movement;

    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");    
    }
}
