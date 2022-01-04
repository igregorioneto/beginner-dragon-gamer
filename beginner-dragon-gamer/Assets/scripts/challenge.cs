using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challenge : MonoBehaviour
{
    public float enemySpeed;
    public float jumpForce;

    private Transform positionPlayer;

    public SpriteRenderer sprintRender;

    public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        positionPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positionPlayer.position, enemySpeed * Time.deltaTime);
        if (positionPlayer.position.x > 0)
        {
            sprintRender.flipX = false;
        }

        if (positionPlayer.position.x < 0)
        {
            sprintRender.flipX = true;
        }
    }

    void FixedUpdate()
    {
        if (positionPlayer.position.x > 0)
        {
            sprintRender.flipX = false;
        }

        if (positionPlayer.position.x < 0)
        {
            sprintRender.flipX = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerLife>().takeDamage();
        }
    }
}
