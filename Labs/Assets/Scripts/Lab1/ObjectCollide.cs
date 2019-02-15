using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollide : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "coin")
        {
            Destroy(col.gameObject, 3.0f);
            Destroy(col.collider, 3.0f);
        }
    }
}
