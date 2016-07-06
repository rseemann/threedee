using UnityEngine;
using System.Collections;

public class TreeController : MonoBehaviour {
	private const string prefabName = "Assets/src/objects/Trunk"; 
	private Object trunkPrefab = null;

	void Start () {
		Debug.Log (prefabName);
		trunkPrefab = Resources.Load (prefabName);
		Instantiate (trunkPrefab);
	}
	
	void Update () {
//		Instantiate (trunkPrefab);
	}
}
