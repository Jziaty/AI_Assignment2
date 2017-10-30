using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[DefaultExecutionOrder(-100)]
public class PlateauBaker : MonoBehaviour {

    NavMeshSurface plateau;

    bool baked = false;

    // Use this for initialization
    void Start () {
        plateau = GetComponent<NavMeshSurface>();
        plateau.Bake();
        baked = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!baked)
            {
                plateau.Bake();
                baked = true;
            }
        }

        else if (Input.GetButtonDown("Fire2"))
        {
            if (baked)
            {
                plateau.RemoveData();
                baked = false;
            }
        }
    }
}
