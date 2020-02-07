using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStick : MonoBehaviour
{
    public Rigidbody2D rig,rig2,rig12,rig21,rig3;
    public Vector2 offset;
    public bool drawOffset = true;

    public float force_multiplier = 10;

    void Update()
    {
        /*if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 force = (rig.position + offset) - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float mag = Mathf.Clamp(force.magnitude, 0, 1.2f);
            force = force.normalized * mag;
            rig.AddForce(-force * Time.deltaTime * 1000 * force_multiplier);
        }*/
        if(Input.GetKey(KeyCode.W))
        {
            rig12.MoveRotation(Mathf.LerpAngle(rig12.rotation, 20, 100 * Time.fixedDeltaTime));
        }
        if(Input.GetKey(KeyCode.S))
        {
            rig.MoveRotation(Mathf.LerpAngle(rig.rotation, 20, 100 * Time.fixedDeltaTime));
        }
        if(Input.GetKey(KeyCode.D))
        {
            rig.MoveRotation(Mathf.LerpAngle(rig.rotation, 45, 40 * Time.fixedDeltaTime));
            //rig12.MoveRotation(Mathf.LerpAngle(rig21.rotation, 45, 40 * Time.fixedDeltaTime));
            //Vector2 force = (rig.position + offset) - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //float mag = Mathf.Clamp(force.magnitude, 0, 1.2f);
            //force = force.normalized * mag;
            //rig.AddForce(-force * Time.deltaTime * 500 * force_multiplier);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.MoveRotation(Mathf.LerpAngle(rig.rotation, -45, 100 * Time.fixedDeltaTime));
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rig21.MoveRotation(Mathf.LerpAngle(rig21.rotation, -20, 100 * Time.fixedDeltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rig2.MoveRotation(Mathf.LerpAngle(rig2.rotation, -20, 100 * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rig2.MoveRotation(Mathf.LerpAngle(rig2.rotation, -45, 100 * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rig2.MoveRotation(Mathf.LerpAngle(rig2.rotation, 45, 100 * Time.fixedDeltaTime));
        }

        if(Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Stand>().work = false;
        }
        else
        {
            gameObject.GetComponent<Stand>().work = true;
        }

        if(Input.GetKey(KeyCode.Alpha6))
        {
            rig3.MoveRotation(Mathf.LerpAngle(rig3.rotation, 45, 100 * Time.fixedDeltaTime));
        }
    }
}
