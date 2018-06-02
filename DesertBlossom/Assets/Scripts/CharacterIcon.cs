using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterIcon : MonoBehaviour
{
    private GameObject topIcon; // 矢印キー"↑"に対応するアイコン
    private GameObject rightIcon; // 矢印キー"→"に対応するアイコン
    private GameObject bottomIcon; // 矢印キー"↓"に対応するアイコン
    private GameObject leftIcon; // 矢印キー"←"に対応するアイコン

    // 各アイコンのプロパティを作成
    public GameObject TopIcon { get { return topIcon; } }
    public GameObject RightIcon { get { return rightIcon; } }
    public GameObject BottomIcon { get { return bottomIcon; } }
    public GameObject LeftIcon { get { return leftIcon; } }

    private bool onPlayer1; // プレイヤー1にセットされているかどうか
    private bool onPlayer2; // プレイヤー2にセットされているかどうか

    // セットするイメージ画像
    [SerializeField] Sprite select_0; // デフォルトのとき
    public Sprite select_1; // プレイヤー1が選択しているとき
    public Sprite select_2; // プレイヤー2が選択しているとき
    [SerializeField] Sprite select_3; // どちらも選択しているとき

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 選択アイコンが切り替わる度にonPlayerを変更。
    public void setIcon(int playerType, GameObject prevIcon)
    {
        CharacterIcon cIcon = prevIcon.GetComponent<CharacterIcon>();

        switch (playerType)
        {
            case 1:
                onPlayer1 = true;
                cIcon.onPlayer1 = false;
                break;
            case 2:
                onPlayer2 = true;
                cIcon.onPlayer2 = false;
                break;
            default:
                break;
        }

        setSprite(gameObject);
        setSprite(prevIcon);
    }

    // アイコンの画像を適切なものに変更する
    private void setSprite(GameObject changeIcon)
    {
        Image iconImg = changeIcon.GetComponent<Image>();

        if (onPlayer1 == true && onPlayer2 == true) // どちらもが選択状態の場合
        {
            iconImg.sprite = select_3;
        }
        else if (onPlayer1 == true) // Player1が選択状態の場合
        {
            iconImg.sprite = select_1;
        }
        else if (onPlayer2 == true) // Player2が選択状態の場合
        {
            iconImg.sprite = select_2;
        }
        else
        {
            iconImg.sprite = select_0;
        }
    }
}
