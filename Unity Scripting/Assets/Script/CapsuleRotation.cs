using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotation : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation; //posibles ejes de movimiento
    public float speed;        //velocidad de movimiento

    void update()
    {
        //Acotación de los valores de dirección  al valor unitario [-1,1]
        rotation = ClampVector3(rotation);


        //Desplazamiento del componente  transform en base  al tiempo
        transform.Rotate(rotation * (speed * Time.deltaTime));
    }
    /*
     * Función auxiliar que permite  acotar los valores  de los componentes
     * de un Vector3 entre -1 y 1.
     */

    public static Vector3 ClampVector3(Vector3 target)
    {
        float clampedX = Mathf.Clamp(target.x, -1f, 1f);
        float clampedY = Mathf.Clamp(target.y, -1f, 1f);
        float clampedZ = Mathf.Clamp(target.z, -1f, 1f);

        Vector3 result = new Vector3(clampedX, clampedY, clampedZ);

        return result;
    }
}
