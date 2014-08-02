using UnityEngine;
using System.Collections;

public class animSpeed : MonoBehaviour {

	public float s = 0.2f;
	public string clipName = "";
	
	void Start()
	{
		gameObject.animation[ clipName ].speed = s;
	}
}
