using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float explosionRadius;
    public float power;
    public SpawnBomb spawner;
    public float fuse = 1f;

    public GameObject explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        spawner = transform.parent.GetComponent<SpawnBomb>();
        Invoke("Detonate", fuse);
        transform.parent = null;
    }


    public void Detonate()
    {
        //adds explosive force to all nearby objects
        Collider[] cols = Physics.OverlapSphere(this.transform.position, explosionRadius);
        
        foreach(Collider col in cols)
        {
            Rigidbody debrisBody = col.GetComponent<Rigidbody>();
            if (debrisBody != null)
            {
                Debug.Log(debrisBody.gameObject);
                debrisBody.AddExplosionForce(power, this.transform.position, power);
            }
        }

        //update attributes
        spawner.mineCount++;
        //spawner.displayMines.text = spawner.mineCount.ToString() + " / 3";
        
        Object.Instantiate(explosionParticle, transform.position,Quaternion.Euler(0f,0f,0f));
        Destroy(this.gameObject);
    }
}
