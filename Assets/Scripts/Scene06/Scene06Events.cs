using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene06Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charGuntharic;
    public GameObject textBox;
    [SerializeField] GameObject charNameLeft;
    [SerializeField] GameObject charNameRight;
    [SerializeField] GameObject goodEndingCanvas;
    [SerializeField] GameObject portCanvas;
    [SerializeField] GameObject menuButton;
    [SerializeField] GameObject quitButton;

    [SerializeField] AudioSource wavesSound;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject exitButton;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;

    void Update()
    {
        textLenght = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        // event 0
        exitButton.SetActive(true);
        charGuntharic.SetActive(true);
        mainTextObject.SetActive(true);
        charNameLeft.SetActive(false);
        charNameRight.SetActive(false);
        textToSpeak = "With a sudden burst of strength, you spin and ram your shoulder into the soldier, knocking him off balance. He falls with a grunt, and in that instant, you wrench your arms free, snapping the rope binding your wrists.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        //event 1
        nextButton.SetActive(false);
        textToSpeak = "The Byzantine soldiers shout in alarm, their hands reaching for weapons. But you don’t hesitate. You bolt toward the trees, your legs burning as you sprint faster than you thought possible.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        // event 2
        nextButton.SetActive(false);
        textToSpeak = "Arrows whistle past you, but you weave through the thickening forest, branches whipping against your face. The shouts of the soldiers grow fainter as the forest swallows you.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 3;
    }
    
    IEnumerator EventThree()
    {
        // event 3
        nextButton.SetActive(false);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        charNameLeft.SetActive(true);
        textToSpeak = "''I must keep running. Don't look back. Just run.''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        charNameLeft.SetActive(false);
        wavesSound.Play();
        textToSpeak = "The trees thicken, and the ground slopes downward. The sound of waves grows louder, closer. You burst through the last line of trees and find yourself at the edge of a rocky path that leads to a small port below.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //event 5
        textBox.SetActive(false);
        nextButton.SetActive(false);
        charNameLeft.SetActive(false);
        charGuntharic.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        textToSpeak = "The port is quiet, a handful of small boats moored along the wooden docks. Fishermen work by the water's edge, oblivious to the chaos behind you. You spot an unattended boat, tied loosely to the dock.";
        textBox.SetActive(true);
        fadeScreenOut.SetActive(false);
        portCanvas.SetActive(true);
        fadeScreenIn.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //event 6
        nextButton.SetActive(false);
        textToSpeak = "The sound of soldiers crashing through the underbrush reaches your ears—they're close. You slip down the rocky slope toward the docks, trying to remain unseen. As you reach the boat, you work quickly, untying the thick rope that binds it to the dock.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 7;
    }

    IEnumerator EventSeven()
    {
        //event 7
        nextButton.SetActive(false);
        charNameRight.GetComponentInChildren<TMPro.TMP_Text>().text = "Byzantine Soldier";
        charNameRight.SetActive(true);
        textToSpeak = "''There! He's down by the port! Don't let him escape!''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 8;
    }

     IEnumerator EventEight()
    {
        //event 8
        nextButton.SetActive(false);
        charNameRight.SetActive(false);
        textToSpeak = "With a final tug, the boat comes free, and you leap into it. Your hands work quickly, grabbing the oars as you push off from the dock. The boat drifts out into the open water, the Byzantine soldiers shouting in frustration as they reach the edge of the docks too late.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 9;
    }

    IEnumerator EventNine()
    {
        //event 9
        nextButton.SetActive(false);
        charNameRight.SetActive(false);
        textToSpeak = "Arrows fly through the air, splashing into the water around you, but the distance between you and the shore grows. You row harder, the muscles in your arms burning with effort. The shoreline recedes behind you, and soon the voices of your pursuers fade into the wind.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 10;
    }

    IEnumerator EventTen()
    {
        //event 10
        nextButton.SetActive(false);
        charNameRight.SetActive(false);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        charNameLeft.SetActive(true);
        textToSpeak = "I've escaped... but where can I go? Everything is lost, but I will survive. For my people. For our memory.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 11;
    }

    IEnumerator EventEleven()
    {
        //event 11
        nextButton.SetActive(false);
        textBox.SetActive(false);
        exitButton.SetActive(false);
        fadeScreenIn.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        goodEndingCanvas.SetActive(true);
        fadeScreenIn.SetActive(true);
        fadeScreenOut.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        menuButton.SetActive(true);
        quitButton.SetActive(true);
    }

    public void NextButton()
    {
        switch (eventPos)
        {
            case 1:
                StartCoroutine(EventOne());
                break;
            case 2:
                StartCoroutine(EventTwo());
                break;
            case 3:
                StartCoroutine(EventThree());
                break;
            case 4:
                StartCoroutine(EventFour());
                break;
            case 5:
                StartCoroutine(EventFive());
                break;
            case 6:
                StartCoroutine(EventSix());
                break;
            case 7:
                StartCoroutine(EventSeven());
                break;
            case 8:
                StartCoroutine(EventEight());
                break;
            case 9:
                StartCoroutine(EventNine());
                break;
            case 10:
                StartCoroutine(EventTen());
                break;
            case 11:
                StartCoroutine(EventEleven());
                break;
            default:
                Debug.Log("Event not found");
                break;
        }
    }
}
