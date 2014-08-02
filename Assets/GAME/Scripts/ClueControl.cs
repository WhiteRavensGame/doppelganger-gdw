using UnityEngine;
using System.Collections;

public class ClueControl : MonoBehaviour {

	public string truthStatement;
	public string lieStatement;

	public bool lying = false;

	public PlayMakerFSM myFSM;


	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter()
	{
		//myFSM.Fsm ("DisplayClue",);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
