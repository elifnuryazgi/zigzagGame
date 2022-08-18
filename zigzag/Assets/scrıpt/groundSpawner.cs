using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    public GameObject ground;
    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            groundSpawn();
        }
    }
    public void groundSpawn()
    {
        Vector3 direction;
        if (Random.Range(0, 2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        ground = Instantiate(ground,ground.transform.position+direction,transform.rotation);
    }
}
