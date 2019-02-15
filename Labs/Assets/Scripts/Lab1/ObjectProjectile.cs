using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProjectile : MonoBehaviour
{
    public GameObject shooter;
    public GameObject bullet;
    public GameObject headset;
    public float bullet_speed;
    private bool use_arrow_key = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            use_arrow_key = !use_arrow_key;
        }
        if (use_arrow_key)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Rotate(Vector3.forward, 100f * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Rotate(Vector3.back, 100f * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.left, -100f * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.left, 100f * Time.deltaTime);
            }
        }

        Quaternion rot;
        rot = transform.rotation;
        rot.z = -headset.transform.GetChild(2).transform.rotation.y;
        transform.rotation = rot;
        rot.x = headset.transform.GetChild(2).transform.rotation.x + 0.6f;
        transform.rotation = rot;

        //rot.z = -headset.transform.GetChild(2).transform.rotation.y - 0.5f;
        //rot.x = headset.transform.GetChild(2).transform.rotation.x + 0.3f;

        //Vector3 rot = new Vector3(temp.x, temp.y, temp.z);
        //float h = 2.0f * Input.GetAxis("Vertical");
        //float v = 2.0f * Input.GetAxis("Horizontal");

        //transform.Rotate(-temp.y * 10.0f, 0, 0);
        //transform.rotation = headset.GetComponent<Camera>().transform.rotation;
        //pos.z = transform.position.z - camera.main.transform.position.z;
        //transform.rotation = Camera.main.ScreenToWorldPoint(pos);

        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject temp_bullet;
        temp_bullet = Instantiate(bullet, shooter.transform.position, shooter.transform.rotation) as GameObject;

        Rigidbody rb;
        rb = temp_bullet.GetComponent<Rigidbody>();
        rb.velocity = transform.up * 40;
        rb.AddForce(transform.up * bullet_speed);
    }
}
