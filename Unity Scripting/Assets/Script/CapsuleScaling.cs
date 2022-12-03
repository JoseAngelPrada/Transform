using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField]
    private Vector3 axes;
    public float scaleUnits;

    void Update ()
    {
        axes = CapsuleMovement.ClampVector3(axes);

        transform.localScale += axes * (scaleUnits * Time.deltaTime);
    }
}
