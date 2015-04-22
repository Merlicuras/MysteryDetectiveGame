using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiplayerNetwork : MonoBehaviour {

	public string connectionIP;
	public int connectionPort;
	
	void Start(){
		//connectionIP = "192.168.0.13";
		connectionPort = 25001;

	}

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}

	void Update () {
	
	}

	public void CreateGame(){
		if (Network.peerType == NetworkPeerType.Disconnected){
			Network.InitializeServer(2, connectionPort, false);
		}
	}

	public void JoinGame(InputField inputField){
		if (Network.peerType == NetworkPeerType.Disconnected)
		{
			if(inputField.text.Length != 0)
			{
			Network.Connect(inputField.text, connectionPort);
			}
			else{
				Debug.Log("Given IP: " + inputField.text);
			}
		}
	}

	public void Disconnect(){
		if (Network.peerType == NetworkPeerType.Client || Network.peerType == NetworkPeerType.Server){
			Network.Disconnect(200);
		}
	}

	void OnConnectedToServer(){
		Debug.Log("Valid IP! :D");
		ButtonLoadLevel loader = GameObject.Find("LoadLevel").GetComponent<ButtonLoadLevel>();
		loader.LoadLevelButton(3);
	}

}
