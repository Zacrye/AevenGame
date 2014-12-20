using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class JsonTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Character c = new Character();
		c.charRace = CharacterRace.Dwarf;
		c.charFaction = EnumFunctions.getFactionFromRace(c.charRace);

		string json = JsonSerializer.Serialize(typeof(Character), c);

		Debug.Log(json);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
