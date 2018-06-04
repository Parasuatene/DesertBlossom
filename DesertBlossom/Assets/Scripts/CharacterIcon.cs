using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterIcon : MonoBehaviour
{
    [SerializeField] GameObject charaObj; // アイコンに対応するキャラクター
    [SerializeField] GameObject topIcon; // 矢印キー"↑"に対応するアイコン
    [SerializeField] GameObject rightIcon; // 矢印キー"→"に対応するアイコン
    [SerializeField] GameObject bottomIcon; // 矢印キー"↓"に対応するアイコン
    [SerializeField] GameObject leftIcon; // 矢印キー"←"に対応するアイコン

    // 各アイコンのプロパティを作成
    public Character Character { get; private set; }
    public GameObject TopIcon { get { return topIcon; } }
    public GameObject RightIcon { get { return rightIcon; } }
    public GameObject BottomIcon { get { return bottomIcon; } }
    public GameObject LeftIcon { get { return leftIcon; } }

    private bool onPlayer1; // プレイヤー1にセットされているかどうか
    private bool onPlayer2; // プレイヤー2にセットされているかどうか

    // セットするイメージ画像
    [SerializeField] Sprite select_0; // デフォルトのとき
    [SerializeField] Sprite select_1; // プレイヤー1が選択しているとき
    [SerializeField] Sprite select_2; // プレイヤー2が選択しているとき
    [SerializeField] Sprite select_3; // どちらも選択しているとき

    private UIManager um;

    private void Awake()
    {
        um = GameObject.Find("Canvas").GetComponent<UIManager>(); // UIManagerを取り付けているオブジェクトをFindしてくる。
        Character = charaObj.GetComponent<Character>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onPlayer1 == true && onPlayer2 == true) // どちらもが選択状態の場合
        {
            gameObject.GetComponent<Image>().sprite = select_3;
        }
        else if (onPlayer1 == true) // Player1が選択状態の場合
        {
            gameObject.GetComponent<Image>().sprite = select_1;
        }
        else if (onPlayer2 == true) // Player2が選択状態の場合
        {
            gameObject.GetComponent<Image>().sprite = select_2;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = select_0;
        }
    }

    // アイコンに画像をセットする(初回のみ呼ばれる)
    public void initSetIcon(PlayerType playerType)
    {
        Image iconImg = gameObject.GetComponent<Image>();
        
        switch (playerType)
        {
            case PlayerType.Player_1:
                onPlayer1 = true;
                break;
            case PlayerType.Player_2:
            case PlayerType.Player_CPU:
                onPlayer2 = true;
                break;
            default:
                break;
        }
    }

    // 選択アイコンが切り替わる度にonPlayerを変更する
    public void setIcon(PlayerType playerType, GameObject prevIcon)
    {
        CharacterIcon cIcon = prevIcon.GetComponent<CharacterIcon>();

        switch (playerType)
        {
            case PlayerType.Player_1:
                onPlayer1 = true;
                cIcon.onPlayer1 = false;
                break;
            case PlayerType.Player_2:
                onPlayer2 = true;
                cIcon.onPlayer2 = false;
                break;
            default:
                break;
        }

        um.setCharaData(playerType, Character.GetComponent<Character>());
    }
}
