using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull_Sc : MonoBehaviour
{
    public float force = 70;
    public Rigidbody2D rg;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 dir = rg.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

            dir = dir.normalized;

            rg.AddForce(-dir * force * Time.deltaTime * 1000);
        }
    }
}
