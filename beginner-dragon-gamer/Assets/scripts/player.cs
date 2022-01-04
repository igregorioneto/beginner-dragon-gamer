using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public Rigidbody2D rigidBody;
    public SpriteRenderer sprintRender;

    float direction;

    // Verificar se o jogador esta no chão
    public bool itsOnTheGround;
    public Transform verifyGround;
    public float verificationRadius;
    public LayerMask layaerGround;

    // Som do pulo
    public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpPlayer();
    }

    void FixedUpdate()
    {
        moviePlayer();
    }

    void moviePlayer()
    {
        direction = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(direction * speed, rigidBody.velocity.y);

        if (direction > 0)
        {
            sprintRender.flipX = false;
        }

        if (direction < 0)
        {
            sprintRender.flipX = true;
        }
    }

    void jumpPlayer()
    {
        itsOnTheGround = Physics2D.OverlapCircle(verifyGround.position, verificationRadius, layaerGround);

        if (Input.GetKeyDown(KeyCode.Space) && itsOnTheGround)
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpSound.Play();
        }
    }
}
