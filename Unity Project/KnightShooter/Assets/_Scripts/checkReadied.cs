﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkReadied : MonoBehaviour {

    public CharMenuController P1View;
    public CharMenuController P2View;
    public CharMenuController P3View;
    public CharMenuController P4View;
    private LoadScene SceneLoader;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (P1View.readied && P2View.readied && P3View.readied && P4View.readied)
        {
            //load random level scene
            //int p = UnityEngine.Random.Range(2, 4);
            SceneLoader.LoadByIndex(2);
        }
    }
}
