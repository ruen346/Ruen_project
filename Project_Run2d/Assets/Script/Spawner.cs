using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn_prefab1;
    public GameObject spawn_prefab2;
    public GameObject spawn_prefab3;
    public GameObject spawn_prefab4;

    public float spawn_delay;

    IEnumerator Start()
    {
        while (true)
        {
            int spawn_choose = Random.Range(1, 5);

            switch(spawn_choose)
            {
                case 1:
                    Instantiate(spawn_prefab1, new Vector2(4.5f, -0.5f), transform.rotation);
                    break;
                case 2:
                    Instantiate(spawn_prefab2, new Vector2(4.5f, -0.5f), transform.rotation);
                    break;
                case 3:
                    Instantiate(spawn_prefab3, new Vector2(4.5f, 0.5f), transform.rotation);
                    break;
                case 4:
                    Instantiate(spawn_prefab4, new Vector2(4.5f, -1.02f), transform.rotation);
                    break;
            }
            
            yield return new WaitForSeconds(spawn_delay + Random.Range(-0.2f, 0.2f));
        }
    }

    void Update()
    {
        
    }
}
