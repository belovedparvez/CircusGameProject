using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stand : MonoBehaviour
{
    public _Muscle[] muscles;
    public bool work=true;
    void FixedUpdate()
    {
        if(work)
        {
            foreach (_Muscle muscle in muscles)
            {
                muscle.ActivateMuscle();
            }
        }
    }
}
[System.Serializable]
public class _Muscle
{
    public Rigidbody2D bone;
    public float restRotation;
    public float force;

    public void ActivateMuscle()
    {
        bone.MoveRotation(Mathf.LerpAngle(bone.rotation, restRotation, force * Time.fixedDeltaTime));
    }
}
