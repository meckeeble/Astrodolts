using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public Text t;
    public int Id;

    private SpawnBomb player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.GetComponent<AddForceMovement>() != null)
        {
            Debug.Log("entered");
            player = collision.gameObject.GetComponentInChildren<SpawnBomb>();
            player.mineCount += 4;
            t.text = player.mineCount.ToString()+" / 3";
            StartCoroutine("Wait", 2.4f);
            
        }
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        player.mineCount -= 4;
        t.text = player.mineCount.ToString()+" / 3";
    }
}
