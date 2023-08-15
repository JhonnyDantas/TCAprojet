using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movi2D : MonoBehaviour
{
    public float Speed = 70;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f ,0f);
        transform.position += movimento * Time.deltaTime * Speed;

        Vector3 Movimento = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += Movimento * Time.deltaTime * Speed;
    }


}
