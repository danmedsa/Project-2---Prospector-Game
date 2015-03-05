using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Prospector : MonoBehaviour {
	static public Prospector S;
	public Deck				 deck;
	public TextAsset 		 deckXML;

	// Use this for initialization
	void Start () {
		deck = GetComponent<Deck> ();
		deck.InitDeck (deckXML.text);
		Deck.Shuffle (ref deck.cards);
	}
	
	// Update is called once per frame
	void Awake () {
		S = this;
	}
}
