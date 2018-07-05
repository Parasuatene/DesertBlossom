using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    [SerializeField] string name; // キャラクターの名前
    [SerializeField] Sprite image;

    public string Name { get { return name; } }
    public Sprite Image { get { return image; } }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
