using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject piece;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("bullet"))
        {
            Instantiate(piece, transform.position, transform.rotation);
        }
    }
}
