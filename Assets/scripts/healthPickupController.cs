using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickupController : MonoBehaviour {

    public float healthAmount;
    public AudioClip healthPickupSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<playerHealth>().addHealth(healthAmount);
            Destroy(transform.root.gameObject);
            AudioSource.PlayClipAtPoint(healthPickupSound, transform.position, 4f);
        }
    }
}
