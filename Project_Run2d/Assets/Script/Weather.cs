using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public GameObject rain;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0.1)
        {
            float x_range = Random.Range(-4f, 8f);
            Instantiate(rain, new Vector2(x_range, 2.5f), transform.rotation);
            time -= 0.1f;
        }

        time += Time.deltaTime;
    }
}
