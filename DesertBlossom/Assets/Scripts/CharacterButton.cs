using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    private Button topBtn; // 矢印キー"↑"に対応するボタン
    private Button rightBtn; // 矢印キー"→"に対応するボタン
    private Button bottomBtn; // 矢印キー"↓"に対応するボタン
    private Button leftBtn; // 矢印キー"←"に対応するボタン

    // 各ボタンのプロパティを作成
    public Button TopBtn { get { return topBtn; } }
    public Button RightBtn { get { return topBtn; } }
    public Button BottomBtn { get { return topBtn; } }
    public Button LeftBtn { get { return topBtn; } }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
