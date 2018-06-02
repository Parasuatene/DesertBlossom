using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    [SerializeField] GameObject currIcon; // 選択状態のアイコン（初期アイコンはインスペクター上から設定）
    private GameObject prevIcon;
    private CharacterIcon cIcon;

    // Use this for initialization
    void Start()
    {
        cIcon = currIcon.GetComponent<CharacterIcon>();
        currIcon.GetComponent<Image>().sprite = cIcon.select_1; // Playerの選択状態の画像にする
    }

    // Update is called once per frame
    void Update()
    {
        // 入力キーに従って、対応するアイコンをセット
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GameObject topIcon = currIcon.GetComponent<CharacterIcon>().TopIcon;
            changeIcon(topIcon);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GameObject rightIcon = currIcon.GetComponent<CharacterIcon>().RightIcon;
            changeIcon(rightIcon);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject bottomIcon = currIcon.GetComponent<CharacterIcon>().BottomIcon;
            changeIcon(bottomIcon);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject leftIcon = currIcon.GetComponent<CharacterIcon>().LeftIcon;
            changeIcon(leftIcon);
        }
    }

    private void changeIcon(GameObject typeIcon)
    {
        if (typeIcon != null)
        {
            prevIcon = currIcon;
            currIcon = typeIcon;
            currIcon.GetComponent<CharacterIcon>().setIcon(1, prevIcon);
        }
    }
}
