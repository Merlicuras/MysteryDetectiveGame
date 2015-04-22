using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private string role; //"Researcher" or "Interviewer".
	private string gender; //"Male" or "Female" for unique dialogue.
	private Journal journal; //Containing clues that are found or shared.

	void Start()
	{
		journal = new Journal();
	}

	private GameObject model; //Errr... TODO: Model.

	public void ShareClues(Journal otherJournal)
	{
		journal.GatherClues(otherJournal);
	}
}
