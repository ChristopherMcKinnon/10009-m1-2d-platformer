// Christopher Lawrick-McKinnon #000983825
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;
    public SpriteRenderer sprite;
    public float speedX;
    public float targetSpeedX;
    public float jumpSpeed;
    public float groundDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        speedX = 5;
        targetSpeedX = speedX;
        jumpSpeed = 5;
    }


    // Update is called once per frame
    void Update()
    {

        // Move Horizontal
        float moveX = Input.GetAxis("Horizontal");
        if (Mathf.Abs(moveX) > 0.1f)
        {
            rb2d.linearVelocityX = moveX * speedX;
        }
        animator.SetFloat("moveSpeedX", Mathf.Abs(moveX)); 

        // Flip Sprite
        if (moveX < 0)
        {
            sprite.flipX = true;
        } else
        {
            sprite.flipX = false;
        }

        // Jump
        if (Input.GetKeyDown("space") && rb2d.linearVelocityY == 0)
        {
            rb2d.linearVelocityY = jumpSpeed;
            animator.SetBool("isGrounded", false);
        }
        else
        {
            animator.SetBool("isGrounded", true);
        }

    }
    public void Kill(Vector3 deathSpot)
    {
        transform.position = deathSpot;
    }
    /*
        // Check to see if player is hitting a wall horizontally
        Vector2 centre = transform.position;
        Vector2 extents = capsuleCollider.bounds.extents;
        float extentsX = isFacingLeft ? -extents.x : +extents.x;
        edgeClipTopOrigin = centre + new Vector2(extentsX, +extents.y);
        edgeClipBotOrigin = centre + new Vector2(extentsX, -extents.y);
        Vector2 direction = Vector2.Normalize(new Vector2(extentsX, 0));
        edgeClipRayDistance = direction * raycastDistance;
        bool hitTop = Physics2D.Raycast(edgeClipTopOrigin, direction, raycastDistance, groundLayer);
        bool hitBot = Physics2D.Raycast(edgeClipBotOrigin, direction, raycastDistance, groundLayer);
        if (hitTop == false && hitBot == false)
        {
            // Set move speed (horizontal) directly, overrides last value
            rb2d.linearVelocityX = moveX * moveSpeed;
        }
        Debug.DrawLine(edgeClipTopOrigin, edgeClipTopOrigin + edgeClipRayDistance, hitTop ? Color.red : Color.green);
        Debug.DrawLine(edgeClipBotOrigin, edgeClipBotOrigin + edgeClipRayDistance, hitBot ? Color.red : Color.green);
        */


}
