using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float speed = 2;
    public float force = 300;
    void OnCollisionEnter2D(Collision2D coll)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
}
