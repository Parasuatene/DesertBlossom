using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Text textType1; // プレイヤー1の選択キャラ名の表示用テキスト
    [SerializeField] Text textType2; // プレイヤー2の選択キャラ名の表示用テキスト
    [SerializeField] Image imageType1;
    [SerializeField] Image imageType2;

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
                textType1.text = character.Name;
                imageType1.sprite = character.Image;
                break;
            case PlayerType.Player_2:
            case PlayerType.Player_CPU:
                textType2.text = character.Name;
                imageType2.sprite = character.Image;
                break;
            default:
                break;
        }
    }
}
