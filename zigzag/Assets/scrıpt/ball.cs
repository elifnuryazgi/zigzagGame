using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public groundSpawner spawnerScript;
    public static bool isfall;
    public float speedekle;
    public skor skorscript;
    private void Start()
    {
        direction = Vector3.forward;//foward ileri demek
        isfall = false;
    }
    private void Update()
    {
        if (transform.position.y <= 0)
        {
            isfall = true;
        }
        if (isfall)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction=Vector3.left;
            }
            else
            {
                direction=Vector3.forward;
            }
        }

    }
    private void FixedUpdate()
    {
        Vector3 move=direction*Time.deltaTime*speed;
        transform.position+=move;
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            speed += speedekle * Time.deltaTime;
            skorscript.updateScore();
            spawnerScript.groundSpawn();
            other.gameObject.AddComponent<Rigidbody>();
            StartCoroutine(GroundDelete(other.gameObject));
        }
    }
    IEnumerator GroundDelete(GameObject DeleteGround)
    {
        yield return new WaitForSeconds(1f);
        Destroy(DeleteGround);
    }
}
