using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KarakterTalk : MonoBehaviour
{
    public TextMeshProUGUI UI_nama;
    public string nama_karakter;
    private Color TalkColor;
    private Color noTalkColor;
    private Image myImage;


    void Start()
    {
        
    }

    
    void Update()
    {
        myImage = GetComponent<Image>();
        TalkColor = new Color32(255, 255, 225, 255);
        noTalkColor = new Color32(106, 106, 106, 255);

        if (UI_nama.text == nama_karakter)
        {
            myImage.color = TalkColor;
        }
        else {
            myImage.color = noTalkColor;
        }
    }
}
