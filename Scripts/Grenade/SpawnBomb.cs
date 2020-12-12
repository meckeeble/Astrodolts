using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SpawnBomb : MonoBehaviour
{
    //Bomb and asssociated parameters
    public GameObject mine;
    public int mineCount;
    public float timer;
    public float throwForce;

    public bool isThrown;

    //UI
    public Text displayMines;

    //Used for coroutines during Update()
    private bool isExecuting;

    public void ThrowBomb(InputAction.CallbackContext ctx)
    {
        isThrown = ctx.ReadValueAsButton();
    }
 
    void Start()
    {
        throwForce = 0;
        //displayMines.text = mineCount.ToString()+ " / 3";
        isExecuting = false;
    }
    
    void Update(){

        if (mineCount > 0)
        {
            if (isThrown)
            {
                //tieing throwForce to framerate probably isn't wise. Will fix later, maybe
                throwForce++;
                throwForce = Mathf.Clamp(throwForce, 0, 40);
            }

            else if (throwForce > 0 && !isThrown)
            {
                //Throw bomb
                GameObject bomb = Object.Instantiate(mine, transform.transform.position, Quaternion.Euler(new Vector3(14f, 0, 0)));
                bomb.transform.parent = this.transform;
                Rigidbody bombRB = bomb.GetComponent<Rigidbody>();
                bombRB.velocity = this.GetComponentInParent<Rigidbody>().velocity;
                bombRB.AddForce(transform.forward * throwForce*1.9f);
                


                //Update bomb count
                mineCount--;
                //displayMines.text = mineCount.ToString()+" / 3";
                throwForce = 0;


            }
        }
        //Remote explosions. May add as power up
        /*
        if (Input.GetMouseButtonDown(1))
        {
            GameObject.FindGameObjectWithTag("Mine").GetComponent<Explode>().Detonate();
            Destroy(GameObject.FindGameObjectWithTag("Mine"));
            mineCount++;
            displayMines.text = mineCount.ToString() + " / 3";
        }
        */

    }
    
}
