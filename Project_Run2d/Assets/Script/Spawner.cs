using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn_prefab1;
    public GameObject spawn_prefab2;
    public GameObject spawn_prefab3;

    public float spawn_delay;

    IEnumerator Start()
    {
        while (true)
        {
            int spawn_choose = Random.Range(1, 4);

            switch(spawn_choose)
            {
                case 1:
                    transform.position = new Vector2(4.5f, -0.5f);
                    Instantiate(spawn_prefab1, transform.position, transform.rotation);
                    break;
                case 2:
                    transform.position = new Vector2(4.5f, -0.5f);
                    Instantiate(spawn_prefab2, transform.position, transform.rotation);
                    break;
                case 3:
                    transform.position = new Vector2(4.5f, 0.5f);
                    Instantiate(spawn_prefab3, transform.position, transform.rotation);
                    break;
            }
            
            yield return new WaitForSeconds(spawn_delay);
        }
    }

    void Update()
    {
        
    }
}
