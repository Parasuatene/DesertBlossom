using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerType
{
    Player_1 = 1, Player_2, Player_CPU
}

public class Player : MonoBehaviour
{
    [SerializeField] PlayerType playerType;
    [SerializeField] protected GameObject currIcon; // 選択中のアイコン
    protected GameObject prevIcon; // 一つ前に選択していたアイコン
    protected CharacterIcon cIcon;
    [SerializeField] string upBtn, rightBtn, downBtn, leftBtn; // Playerに対応するボタン

    public static Character selectChara { get; set; } // 選択したキャラクター

    // Use this for initialization
    protected void Start()
    {
        cIcon = currIcon.GetComponent<CharacterIcon>();
        GameObject.Find("Canvas").GetComponent<UIManager>().setCharaData(playerType, cIcon.Character);
        cIcon.initSetIcon(playerType);
    }

    // Update is called once per frame
    void Update()
    {
        // 入力キーに従って、対応するアイコンをセット（今後、コントローラーなどで操作する際は入力キーを変更する。）
        if (Input.GetButtonDown(upBtn))
        {
            GameObject topIcon = currIcon.GetComponent<CharacterIcon>().TopIcon;
            changeIcon(topIcon);
        }
        else if (Input.GetButtonDown(rightBtn))
        {
            GameObject rightIcon = currIcon.GetComponent<CharacterIcon>().RightIcon;
            changeIcon(rightIcon);
        }
        else if (Input.GetButtonDown(downBtn))
        {
            GameObject bottomIcon = currIcon.GetComponent<CharacterIcon>().BottomIcon;
            changeIcon(bottomIcon);
        }
        else if (Input.GetButtonDown(leftBtn))
        {
            GameObject leftIcon = currIcon.GetComponent<CharacterIcon>().LeftIcon;
            changeIcon(leftIcon);
        }
    }

    protected void changeIcon(GameObject typeIcon)
    {
        if (typeIcon != null)
        {
            prevIcon = currIcon;
            currIcon = typeIcon;
            currIcon.GetComponent<CharacterIcon>().setIcon(playerType, prevIcon);
        }
    }
}
