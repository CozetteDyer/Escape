using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;
    private bool isAttack;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //flip the player when they change direction
        if (horizontalInput > 0.1f)
        {
            transform.localScale = new Vector3(1,1,1);
        } else if (horizontalInput < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }
        if (Input.GetMouseButtonDown(1)) // right click
        {
            isAttack = true;
            anim.SetTrigger("isAttack");
            var projectile = Instantiate(ProjectilePrefab, LaunchOffset.position, gameObject.transform.rotation);
            
        }
        if (Input.GetMouseButtonUp(1))
        {
            isAttack = false;
            anim.SetTrigger("isAttack");
        }



        //set animator parameters
        anim.SetBool("running", horizontalInput !=0);
        anim.SetBool("grounded", grounded);
        anim.SetBool("isAttack", isAttack);
    }

    private void Jump()
    {
        body.velocity = new Vector3(body.velocity.x, speed);
        anim.SetTrigger("Jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
