﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreenController : MonoBehaviour {


	public GameObject wins1;
	public GameObject wins2;
	public GameObject wins3;
	public Image charBody;
	public Image charFace;
	public Material border;
	public CharacterCardController card;
    public Material glow;
	private variableTracker varTracker;
	private bool transformed;

    // Use this for initialization
    void Start () {
		varTracker = GameObject.Find("variableTracker").GetComponent<variableTracker>();
    }
	
	// Update is called once per frame
	void Update () {
		if (varTracker.pointsDelivered && !varTracker.winDone) 
		{
            this.transform.position = Mathf.Lerp(this.transform.position.x, this.transform.position.x + 20, 2);
			transformed = true;
			if (transformed) 
			{
				if (card.wins1.enabled) 
				{
                    wins1.GetComponent<Renderer>().material = glow;
                }
				if (card.wins2.enabled) 
				{
                    wins2.GetComponent<Renderer>().material = glow;
                }
				if (card.wins3.enabled) 
				{
                    wins3.GetComponent<Renderer>().material = glow;
                }
				varTracker.winDone = true;
			}
		}
	}
}
