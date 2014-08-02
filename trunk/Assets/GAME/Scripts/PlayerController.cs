using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private GameObject player1Model;
	[SerializeField]
	private GameObject player2Model;
	[SerializeField]
	private GameObject player3Model;
	[SerializeField]
	private GameObject doppelgangerModel;

	[SerializeField]
	private GameObject player1PelvisRoot;
	[SerializeField]
	private GameObject player2PelvisRoot;
	[SerializeField]
	private GameObject player3PelvisRoot;
	[SerializeField]
	private GameObject doppelgangerPelvisRoot;

	private bool isDoppelganger = false;

	private int heldKey = 0;

	private int typeID = -2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AssignCharacterType(int index)
	{
		if (index == 0) 
		{
			isDoppelganger = true;
			doppelgangerModel.SetActive(true);
			doppelgangerPelvisRoot.SetActive(true);
		}
		else if(index == 1)
		{
			player1Model.SetActive(true);
			player1PelvisRoot.SetActive(true);
		}
		else if(index == 2)
		{
			player2Model.SetActive(true);
			player2PelvisRoot.SetActive(true);
		}
		else if(index == 3)
		{
			player3Model.SetActive(true);
			player3PelvisRoot.SetActive(true);
		}

		typeID = index;
	}

}
