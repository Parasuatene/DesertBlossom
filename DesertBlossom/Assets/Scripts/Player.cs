﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] protected GameObject currIcon; // 選択中のアイコン
    protected GameObject prevIcon;
    protected CharacterIcon cIcon;
    protected int playerNum; // Playerの種類を判別する

    // Use this for initialization
    protected void Start()
    {
        cIcon = currIcon.GetComponent<CharacterIcon>();
        cIcon.initSetIcon(playerNum);
    }

    // Update is called once per frame
    void Update()
    {
    }

    protected void changeIcon(GameObject typeIcon)
    {
        if (typeIcon != null)
        {
            prevIcon = currIcon;
            currIcon = typeIcon;
            currIcon.GetComponent<CharacterIcon>().setIcon(playerNum, prevIcon);
        }
    }
}
