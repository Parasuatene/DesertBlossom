using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

// モード選択を行うクラス
public class ModeSelect : MonoBehaviour
{
    // モードの番号(1:一人プレイモード, 2:二人プレイモード)
    public static int mode { get; set; }

    private Button selectBtn; // 選択中のボタン

    // Use this for initialization
    void Start()
    {
        selectBtn = GameObject.Find("ModeSelect/Panel/Play_1").GetComponent<Button>();
        selectBtn.Select();
    }

    /// <summary>
    /// クリックしたボタンによってmodeの値を変更
    /// </summary>
    /// 
    /// <param name="number">ボタンが持つパラメータ</param>
    public void OnClick(int number)
    {
        switch (number)
        {
            case 1:
            case 2:
                mode = number;
                SceneManager.LoadScene("CharacterSelect");
                break;
            default:
                break;
        }
    }
}
