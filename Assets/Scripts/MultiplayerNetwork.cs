using UnityEngine;
using System.Collections;

public class MultiplayerNetwork : MonoBehaviour {

	public string connectionIP;
	public int connectionPort;
	
	void Start(){
		connectionIP = "192.168.0.13";
		connectionPort = 25001;
	}
	
	void Update () {
	
	}

	public void CreateGame(){
		if (Network.peerType == NetworkPeerType.Disconnected){
			Network.InitializeServer(2, connectionPort, false);
		}
	}

	public void JoinGame(){
		if (Network.peerType == NetworkPeerType.Disconnected){
			Network.Connect(connectionIP, connectionPort);
		}
	}

	public void Disconnect(){
		if (Network.peerType == NetworkPeerType.Client || Network.peerType == NetworkPeerType.Server){
			Network.Disconnect(200);
		}
	}
	
}
