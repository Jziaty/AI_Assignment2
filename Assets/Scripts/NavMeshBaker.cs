using UnityEngine;
using UnityEngine.AI;

[DefaultExecutionOrder(-100)]
public class NavMeshBaker : MonoBehaviour 
{
	NavMeshSurface surface;

    bool baked = false;


    void Start()
	{
		surface = GetComponent<NavMeshSurface> ();
		surface.Bake ();
        baked = true;
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
        {
            if (!baked)
            {
                surface.Bake();
                baked = true;
            }
                
            
        }
			
		else if (Input.GetButtonDown("Fire2"))
        {
            if (baked)
            {
                surface.RemoveData();
                baked = false;
            }
                
            
        }
			
	}
}
