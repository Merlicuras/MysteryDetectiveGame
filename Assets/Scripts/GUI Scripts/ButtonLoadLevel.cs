using UnityEngine;
using System.Collections;

public class ButtonLoadLevel : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
	}

	public void LoadLevelButton (int index){
		Application.LoadLevel(index);
	}

	public void LoadLevelButton (string levelName){
		Application.LoadLevel(levelName);
	}
}
