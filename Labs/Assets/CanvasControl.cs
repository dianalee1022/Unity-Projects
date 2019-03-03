using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    public GameObject particle;
    public Text gValue;
    public Slider gSlider;


    private float currGValue = -9.8f;
    private readonly float MIN_GRAVITY = 10f;
    private readonly float MAX_GRAVITY = -20f;
    private List<GameObject> particleList;

    // // Start is called before the first frame update
    void Start()
    {
      // Gravity usually takes a negative value
      // as it's applied away from the earth.
      // For user's sake, it'll be displayed as a positive value on UI.
      gSlider.minValue = -MIN_GRAVITY;
      gSlider.maxValue = -MAX_GRAVITY;
      float tempG = -currGValue;
      gValue.text = tempG.ToString("0.0");
      gSlider.value = tempG;
      particleList = new List<GameObject>();
    }

    void Update() {
        gSlider.onValueChanged.AddListener((value) => {
            currGValue = -value;
            gValue.text = value.ToString("0.0");
        });
    }

    public void AddParticles() {
        GameObject temp_particle;
        float x = Random.Range(-25, 35);
        float y = Random.Range(5, 20);
        float z = Random.Range(0, 30);
        Vector3 pos = new Vector3(x, y, z);
        temp_particle = Instantiate(particle, pos, Random.rotation) as GameObject;
        temp_particle.GetComponent<Rigidbody>().useGravity = false;
        particleList.Add(temp_particle);
        // Rigidbody rb;
        // rb = temp_particle.GetComponent<Rigidbody>();
        // rb.velocity = transform.up * 40;
        // rb.AddForce(transform.up * bullet_speed);
    }

    public void ApplyGravity() {
        Physics.gravity = new Vector3(0, currGValue, 0);
        foreach (GameObject obj in particleList) {
          obj.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    public void OffGravity() {
      foreach (GameObject obj in particleList) {
        obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
        obj.GetComponent<Rigidbody>().useGravity = false;
      }
    }

    public void ApplyImpulseForce() {
      foreach (GameObject obj in particleList) {
        Vector3 imForce = new Vector3(Random.Range(-20,20), Random.Range(-20,20), Random.Range(0,20));
        obj.GetComponent<Rigidbody>().AddForce(imForce, ForceMode.Impulse);
      }
    }
}
