using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning(other.name);
        if (other.transform.name == "Bollards")
        {
            Destroy(other);
            Debug.LogError("Destroyed " + other.name);
        }
    }
}
