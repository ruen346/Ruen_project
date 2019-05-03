using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed;
    public float angle = 0;
    public int destroy_time = 5;
    public bool turn_true = false;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroy_time);
    }

    // Update is called once per frame
    void Update()
    {
        if (turn_true)
        {
            transform.Rotate(Vector3.forward, -angle);
        }

        transform.Translate(-speed * Time.deltaTime, 0, 0);

        if (turn_true)
        {
            angle += Time.deltaTime * 300;
            transform.Rotate(Vector3.forward, angle);
        }
    }
}
