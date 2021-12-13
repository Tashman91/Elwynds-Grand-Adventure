using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;

    public Rigidbody2D rB;

    Vector2 movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rB.MovePosition(rB.position * movement * moveSpeed * Time.fixedDeltaTime);
    }
}
