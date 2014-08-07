using UnityEngine;
using System.Collections;

public class ChangeDoppelgangerForm : MonoBehaviour
{
	
	//public Transform player;			// Reference to the player's transform.
	//private Vector3 relCameraPos;		// The relative position of the camera from the player.
	//private float relCameraPosMag;		// The distance of the camera from the player.
	//private Vector3 newPos;				// The position the camera is trying to reach.


	public SkinnedMeshRenderer smr;
	public Mesh[] characterMeshes;
	public Mesh doppelgangerMesh;

	public Material[] p1Materials;
	public Material[] p2Materials;
	public Material[] p3Materials;
	public Material[] doppelgangerMaterials;
	public Material[] invisibleMaterials;
	
	void Start ()
	{

	}

	public void SwitchToP1()
	{
		smr.materials = p1Materials;
		smr.sharedMesh = characterMeshes [0];
	}
	public void SwitchToP2()
	{
		smr.materials = p2Materials;
		smr.sharedMesh = characterMeshes [1];
	}
	public void SwitchToP3()
	{
		smr.materials = p3Materials;
		smr.sharedMesh = characterMeshes [2];
	}
	public void SwitchToDP()
	{
		smr.materials = doppelgangerMaterials;
		smr.sharedMesh = doppelgangerMesh;
	}
	public void SwitchToInvisible()
	{
		smr.materials = invisibleMaterials;
		smr.sharedMesh = doppelgangerMesh;
	}



	

}
