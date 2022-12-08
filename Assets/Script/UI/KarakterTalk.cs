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

    
    void Update()
    {
        myImage = GetComponent<Image>(); //Ambil Gambar
        TalkColor = new Color32(255, 255, 225, 255); //Brightness 100%
        noTalkColor = new Color32(106, 106, 106, 255); //Brightness 50%

        //Bila UI_nama sesuai dengan nama_karakternya, maka gambar cerah
        if (UI_nama.text == nama_karakter)
        {
            myImage.color = TalkColor;
        }
        else {
            myImage.color = noTalkColor;
        }
    }
}
