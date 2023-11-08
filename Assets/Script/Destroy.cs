using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject piece;
    public GameObject leavePiece;
    public GameObject woodPiece;

    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(leavePiece, SpawnPoint1.position, SpawnPoint1.rotation);
        Instantiate(leavePiece, SpawnPoint2.position, SpawnPoint2.rotation);
        Instantiate(woodPiece, SpawnPoint3.position, SpawnPoint3.rotation);
    }
}
