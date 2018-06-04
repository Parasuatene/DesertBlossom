using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Text txtType1; // プレイヤー1の選択キャラ名の表示用テキスト
    [SerializeField] Text txtTYpe2; // プレイヤー2の選択キャラ名の表示用テキスト

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setCharaData(int playerType, string charaName)
    {
        if (playerType == 1)
        {
            txtType1.text = charaName;
        }
        else if (playerType == 2)
        {
            txtTYpe2.text = charaName;
        }
    }
}
