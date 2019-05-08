using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float jump_power = 1;

    Rigidbody2D rigid;

    Vector2 movement;
    bool jump = false;

    float slide_delay = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Slide_back")
        {
            if(slide_delay == 0)
            {
                transform.Rotate(0, 0, 30);
                collision.transform.Translate(-0.8f, 0, 0);
                slide_delay = 1;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && transform.position.y <= -0.45 && (transform.rotation.z < 0.5 && transform.rotation.z > -0.5))
            jump = true;
        if(transform.rotation.z > 0.5 || transform.rotation.z < -0.5)
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0, Space.World);
        }

        if (transform.position.x < -4.5 && Game_system.get_play() == 1)
        {
            FindObjectOfType<Game_system>().game_end();
        }
    }

    void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if (!jump)
            return;

        rigid.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jump_power);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

        jump = false;
    }
}
