using UnityEngine;
using UnityEngine.AI;

[DefaultExecutionOrder(-100)]
public class NavMeshBaker : MonoBehaviour 
{
    NavMeshSurface platSurface;

	NavMeshSurface surface;



	void Start()
	{
		surface = GetComponent<NavMeshSurface> ();
		surface.Bake ();
        platSurface = GameObject.FindGameObjectWithTag("Plateau").GetComponent<NavMeshSurface>();
        platSurface.Bake();

	}

	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
        {
            surface.Bake();
            platSurface.Bake();
        }
			
		else if (Input.GetButtonDown("Fire2"))
        {
            platSurface.RemoveData();
            surface.RemoveData();
            
        }
			
	}
}
