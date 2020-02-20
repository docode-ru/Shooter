using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Gameplay/Timed Self-Destruct Pooled")]
public class TimedSelfDestructPooled: MonoBehaviour
{

	// After this time, the object will be destroyed
	public float timeToDestruction;


	void Start ()
	{
		Invoke("DestroyMe", timeToDestruction);
	}


	// This function will destroy this object :(
	void DestroyMe()
	{
		Invoke("DestroyMe", timeToDestruction);
		gameObject.SetActive(false);

		// Bye bye!
	}
}
