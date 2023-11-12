using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public AudioSource shoot;
    public AudioSource drive;

    public float speed = 5;
    public float rotateSpeed = 90;

    public string vertical;
    public string horizontal;

    public KeyCode shootKey;

    public GameObject bullet;
    public Transform shootPoint;

    // Update is called once per frame
    void Update()
    {
        var ver = Input.GetAxis(vertical);
        //transform.position += transform.forward * speed * ver * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = transform.forward * speed * ver;

        var hor = Input.GetAxis(horizontal);
        transform.Rotate(0, rotateSpeed * hor * Time.deltaTime, 0);

        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            shoot.Play();
        }
        if (Input.anyKeyDown)
        {
            drive.Play();
        }
        else
        {
            drive.Stop();
        }
    }
}
