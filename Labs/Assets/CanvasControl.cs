using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    public GameObject particle;

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // Change Light
    public void ChangeLightIntensity(GameObject lightSelector, GameObject lightSource) {
        
        Debug.Log(this.name);
        // GameObject lt = Gameobject.FindGameObjectsWithTag("lights_hall");
        // print("potatoes");
    }

    public void AddParticles() {
        // GameObject temp_particle;
        // temp_particle = Instantiate(particle, shooter.transform.position, shooter.transform.rotation) as GameObject;

        // Rigidbody rb;
        // rb = temp_particle.GetComponent<Rigidbody>();
        // rb.velocity = transform.up * 40;
        // rb.AddForce(transform.up * bullet_speed);
    }
}
