using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Demo2Controller : MonoBehaviour
{
    static NavMeshSurface platSurface;

    static NavMeshSurface surface;

	void Start () 
	{
        if(surface == null)
		    surface = GetComponent<NavMeshSurface> ();

        if(platSurface == null)
        {
            platSurface = GameObject.FindGameObjectWithTag("Plateau").GetComponent<NavMeshSurface>();
        }
	}

	public static void Bake()
	{
        if(surface != null)
		    surface.Bake ();

        if (platSurface != null)
            platSurface.Bake();

	}
}
