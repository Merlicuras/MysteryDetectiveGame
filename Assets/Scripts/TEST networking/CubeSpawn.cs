using UnityEngine;
using System.Collections;

public class CubeSpawn : MonoBehaviour {

	public GameObject playerPrefab;
	
	void Start () {
	
	}

	void Update () {
	
	}

	void OnServerInitialized(){
		SpawnPlayer();
	}
	
	void OnConnectedToServer(){
		SpawnPlayer();
	}
	
	private void SpawnPlayer(){
		Network.Instantiate(playerPrefab, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
	}
}
