using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    private Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);


        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
        
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {

                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
            }
        }
    }
}
