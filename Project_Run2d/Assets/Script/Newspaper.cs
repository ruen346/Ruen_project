using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    public float speed;
    public float angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, -angle);
        transform.Translate(-speed * Time.deltaTime, 0, 0);

        angle += Time.deltaTime * 300;
        transform.Rotate(Vector3.forward, angle);
    }
}
