using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    [SerializeField]Image firstIcon; // 初めに選択状態にするアイコン
    
    // Use this for initialization
    void Start()
    {
        firstIcon.GetComponent<CharacterIcon>().setImage();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
