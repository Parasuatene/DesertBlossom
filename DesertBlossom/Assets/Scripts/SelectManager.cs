using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    [SerializeField] GameObject curIcon; // 選択状態のアイコン（初期アイコンはインスペクター上から設定）
    private GameObject prevIcon;
    private CharacterIcon cIcon;

    // Use this for initialization
    void Start()
    {
        cIcon = curIcon.GetComponent<CharacterIcon>();
        curIcon.GetComponent<Image>().sprite = cIcon.select_1; // Playerの選択状態の画像にする
    }

    // Update is called once per frame
    void Update()
    {
        // 入力キーに従って、対応するアイコンをセット
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GameObject topIcon = curIcon.GetComponent<CharacterIcon>().TopIcon;
            changeIcon(topIcon);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GameObject rightIcon = curIcon.GetComponent<CharacterIcon>().RightIcon;
            changeIcon(rightIcon);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject bottomIcon = curIcon.GetComponent<CharacterIcon>().BottomIcon;
            changeIcon(bottomIcon);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject leftIcon = curIcon.GetComponent<CharacterIcon>().LeftIcon;
            changeIcon(leftIcon);
        }
    }

    private void changeIcon(GameObject typeIcon)
    {
        if (typeIcon != null)
        {
            prevIcon = curIcon;
            curIcon = typeIcon;
            curIcon.GetComponent<CharacterIcon>().setIcon(1, prevIcon);
        }
    }
}
