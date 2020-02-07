using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStick : MonoBehaviour
{
    public Rigidbody2D LowerLegL,UpperLegL,LowerLegR,UpperLegR;
    public Vector2 offset;
    public bool drawOffset = true;
    float keyForce=60;
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

        if (Input.GetKey(KeyCode.W))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 180, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, -45, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 45, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, -90, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 90, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, -20, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, -20, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            UpperLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 20, keyForce * Time.fixedDeltaTime));
            LowerLegL.MoveRotation(Mathf.LerpAngle(UpperLegL.rotation, 20, keyForce * Time.fixedDeltaTime));
        }


        //RightLeg
        if (Input.GetKey(KeyCode.UpArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 180, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, -45, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 45, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, -90, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 90, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 0, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, -20, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, -20, keyForce * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            UpperLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 20, keyForce * Time.fixedDeltaTime));
            LowerLegR.MoveRotation(Mathf.LerpAngle(UpperLegR.rotation, 20, keyForce * Time.fixedDeltaTime));
        }


        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Stand>().work = false;
        }
        else
        {
            gameObject.GetComponent<Stand>().work = true;
        }
    }
}
