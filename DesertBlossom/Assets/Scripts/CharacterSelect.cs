using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

    private Button selectBtn; // 選択中のボタン

	// Use this for initialization
	void Start () {
        selectBtn = GameObject.Find("Canvas/Panel/Button1").GetComponent<Button>();
        selectBtn.Select();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
