using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterIcon : MonoBehaviour
{
    private Image topIcon; // 矢印キー"↑"に対応するアイコン
    private Image rightIcon; // 矢印キー"→"に対応するアイコン
    private Image bottomIcon; // 矢印キー"↓"に対応するアイコン
    private Image leftIcon; // 矢印キー"←"に対応するアイコン

    // 各アイコンのプロパティを作成
    public Image TopIcon { get { return topIcon; } }
    public Image RightIcon { get { return rightIcon; } }
    public Image BottomIcon { get { return bottomIcon; } }
    public Image LeftIcon { get { return leftIcon; } }

    // セットするイメージ画像
    [SerializeField] Sprite select_0; // デフォルトのとき
    [SerializeField] Sprite select_1; // プレイヤー1が選択しているとき
    [SerializeField] Sprite select_2; // プレイヤー2が選択しているとき
    [SerializeField] Sprite select_3; // どちらも選択しているとき

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setImage()
    {
        
    }
}
