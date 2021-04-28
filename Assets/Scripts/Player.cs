using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    public float moveSpeed = 4f;
    
    void Update() {
        HandleMovement();
    }
    
    void HandleMovement() {
        if(isLocalPlayer) {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            print(moveHorizontal);
            Vector3 movement = new Vector3(moveHorizontal * moveSpeed * 0.01f, transform.position.y, 0);
            transform.position = transform.position + movement;
        }
    }
}