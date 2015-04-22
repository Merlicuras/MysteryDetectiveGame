using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Image))]
public class ShowModel : MonoBehaviour {

	public Sprite maleSprite;
	public Sprite femaleSprite;

	private Image model;

	void Start () {
		model = GameObject.Find("Your Character").GetComponent<Image>();
		Debug.Log(model.name);
	}
	
	void Update () {
		
	}

	public void ShowFemale(){
		model.overrideSprite = femaleSprite;
	}

	public void ShowMale(){
		model.overrideSprite = maleSprite;
	}

}
