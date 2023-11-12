using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject particle;
    public int particleCount;
    public int hp;

    public AudioSource destroy;
    public AudioSource hit;

    public void Damage()
    {
        hp--;
        hit.Play();
        if (hp <= 0)
        {
            Die(); 
            destroy.Play();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        
        for (int i = 0; i < particleCount; i++)
        {
            var offset = Random.insideUnitSphere * 2;
            Instantiate(particle, transform.position + offset + Vector3.up, transform.rotation);
        }
    }
}
