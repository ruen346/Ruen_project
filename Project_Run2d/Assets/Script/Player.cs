using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jump_power = 1;

    Rigidbody2D rigid;

    Vector2 movement;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && transform.position.y <= -0.45)
            jump = true;

        if (transform.rotation.z > 0.5 && transform.position.y <= -0.45)
        {
            jump = false;
            transform.Translate(0, 3 * Time.deltaTime, 0);
        }
        else if (transform.rotation.z < -0.5 && transform.position.y <= -0.45)
        {
            jump = false;
            transform.Translate(0, -3 * Time.deltaTime, 0);
        }
        //뒤집혔을 경우도 해야됨
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
