using UnityEngine;

public class Teleport : MonoBehaviour {

	public bool teleported = false;
	public Teleport target;
	
	void OnTriggerEnter (Collider other)
	{
		if (other)
		{
			if (!teleported)
			{
				target.teleported = true;
				other.gameObject.transform.position = target.gameObject.transform.position;
				other.gameObject.transform.rotation = target.gameObject.transform.rotation;
			}
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			teleported = false;
		}
	}
}
