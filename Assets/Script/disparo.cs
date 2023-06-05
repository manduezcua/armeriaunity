using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class disparo : MonoBehaviour
{
    //public GameObject projectile;
    public Rigidbody projectile;
    public Transform posicion;
    
    void Update()
    {

    }
    public void Disparar()
    {
        
        // Instantiate the projectile at the position and rotation of this transform
        Rigidbody clone;
        clone = Instantiate(projectile, posicion.position, posicion.rotation);

        // Give the cloned object an initial velocity along the current
        // object's Z axis
        clone.velocity = transform.TransformDirection(Vector3.forward * -15);
    }
}
