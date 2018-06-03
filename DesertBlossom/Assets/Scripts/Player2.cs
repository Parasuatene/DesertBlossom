﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : Player
{
    // Use this for initialization
    new void Start()
    {
        playerNum = 2;
        base.Start(); // 親のStart関数を呼び出し
    }

    // Update is called once per frame
    void Update()
    {
        // 入力キーに従って、対応するアイコンをセット（今後、コントローラーなどで操作する際は入力キーを変更する。）
        if (Input.GetButtonDown("Player1_Up"))
        {
            GameObject topIcon = currIcon.GetComponent<CharacterIcon>().TopIcon;
            changeIcon(topIcon);
        }
        else if (Input.GetButtonDown("Player1_Right"))
        {
            GameObject rightIcon = currIcon.GetComponent<CharacterIcon>().RightIcon;
            changeIcon(rightIcon);
        }
        else if (Input.GetButtonDown("Player1_Down"))
        {
            GameObject bottomIcon = currIcon.GetComponent<CharacterIcon>().BottomIcon;
            changeIcon(bottomIcon);
        }
        else if (Input.GetButtonDown("Player1_Left"))
        {
            GameObject leftIcon = currIcon.GetComponent<CharacterIcon>().LeftIcon;
            changeIcon(leftIcon);
        }
    }
}
