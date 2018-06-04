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

    public void setCharaData(int playerType, Character character)
    {
        if (playerType == 1)
        {
            textType1.text = character.name;
        }
        else if (playerType == 2)
        {
            textType2.text = character.name;
        }
    }
}
