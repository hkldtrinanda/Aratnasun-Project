using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog : MonoBehaviour
{
    //Deklar
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI namaCharacter;
    public GameObject BGUI;
    public GameObject Char1;
    public GameObject Char2;
    public GameObject player;
    public string[] name_character_di_sentences; //nama karakter di sentences N
    public string[] sentences; //Banyak Sentences
    public float typingSpeed; //Kecepatan ketik
    public bool textIsDone = false;
    private int index;

    public GameObject continueButton; //Tombol Next

    void Start()
    {
        //Disable Movement Player
        player.GetComponent<WalkingSimulator>().enabled = false;
        if (player.GetComponent<LadderScript>() != null) { 
            player.GetComponent<LadderScript>().enabled = false;
        }

        StartCoroutine(Type());
    }

    void Update()
    {
        //Bila text sudah selesai ditampilkan maka tombol next muncul
        if (textDisplay.text == sentences[index]) {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type() {

        //Setting Nama Karakter yang Berbicara
        string name = name_character_di_sentences[index];
        namaCharacter.text = name;

        //Clear Text Area
        textDisplay.text = "";
        
        //Text Diketik sesuai kecepatan
        foreach (char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence() {
        
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            namaCharacter.text = "";
            StartCoroutine(Type());
        }
        else {
            textDisplay.text = "";
            namaCharacter.text = "";

            //Menghilangkan UI Dialog bila sudah selesai
            continueButton.SetActive(false);
            BGUI.SetActive(false);
            if (Char1 != null) { 
                Char1.SetActive(false);
            }
            if (Char2 != null) { 
                Char2.SetActive(false);
            }

            //Enable Movement Player
            textIsDone = true;
            player.GetComponent<WalkingSimulator>().enabled = true;
            player.GetComponent<LadderScript>().enabled = true;
        }
    }
}
