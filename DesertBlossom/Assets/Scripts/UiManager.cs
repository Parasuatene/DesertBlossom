using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Text textType1; // プレイヤー1の選択キャラ名の表示用テキスト
    [SerializeField] Text textType2; // プレイヤー2の選択キャラ名の表示用テキスト

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setCharaData(PlayerType playerType, Character character)
    {
        switch (playerType)
        {
            case PlayerType.Player_1:
                textType1.text = character.name;
                break;
            case PlayerType.Player_2:
            case PlayerType.Player_CPU:
                textType2.text = character.name;
                break;
            default:
                break;
        }
    }
}
