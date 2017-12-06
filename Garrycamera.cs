using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garrycamera : MonoBehaviour
{
    public Transform player;

    public bool bound;
    public Vector3 minCameraPos;
    public Vector3 maxCameraPos; 
	
	void Start () {
		
	}
	
	
	void Update ()
    {
        transform.position = new Vector3(player.position.x,player.position.y,transform.position.z);

        if (bound)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
                Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
                Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
                
        }
    }

}
