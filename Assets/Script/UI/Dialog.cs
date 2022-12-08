using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI namaCharacter;
    public GameObject BGUI;
    public GameObject Char1;
    public GameObject Char2;
    public GameObject player;
    public string[] name_character_di_sentences;
    public string[] sentences;
    public float typingSpeed;
    private int index;

    public GameObject continueButton;

    void Start()
    {
        player.GetComponent<WalkingSimulator>().enabled = false;
        player.GetComponent<LadderScript>().enabled = false;
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == sentences[index]) {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type() {

        string name = name_character_di_sentences[index];
        namaCharacter.text = name;
        textDisplay.text = "";

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
            continueButton.SetActive(false);
            BGUI.SetActive(false);
            Char1.SetActive(false);
            Char2.SetActive(false);
            player.GetComponent<WalkingSimulator>().enabled = true;
            player.GetComponent<LadderScript>().enabled = true;
        }
    }
}
