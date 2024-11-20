using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene03Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charGuntharic;
    public GameObject charBelisarius;
    public GameObject textBox;
    [SerializeField] GameObject charNameRight;

    [SerializeField] AudioSource cheer2Sound;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject exitButton;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject choiceLeftButton;
    [SerializeField] GameObject choiceRightButton;
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
        fadeScreenIn.SetActive(true);
        fadeScreenOut.SetActive(false);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        exitButton.SetActive(true);
        charNameRight.SetActive(false);
        textToSpeak = "Dust swirls in the wind as both sides brace for the clash on the battlefield. On one side, the Vandal warriors—fierce but outnumbered. On the other, the disciplined Byzantine forces, led by the brilliant general Belisarius.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        fadeScreenIn.SetActive(false);
        nextButton.SetActive(true);
        //the event position becomes 1
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        // event 1
        nextButton.SetActive(false);
        charNameRight.SetActive(true);
        charBelisarius.SetActive(true);
        charNameRight.GetComponentInChildren<TMPro.TMP_Text>().text = "General Belisarius";
        textToSpeak = "''Hold the line. Let them come. Do not break formation until I give the command. The Vandals are reckless. Let them tire themselves against our shields. When their ranks falter, we strike.''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 1
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        // event 2
        nextButton.SetActive(false);
        charNameRight.SetActive(false);
        textToSpeak = "The Vandals crash into the Byzantine shield wall, and a fierce clash ensues. Despite the chaos, the Byzantine soldiers remain disciplined, their formations steady. Belisarius rides along the rear of his army, his sharp eyes watching every movement.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 2
        eventPos = 3;
    }
    
    IEnumerator EventThree()
    {
        // event 3
        nextButton.SetActive(false);
        charNameRight.SetActive(true);
        textToSpeak = "''Send the cavalry to flank them on the right. Do not overextend—cut off their retreat, and drive them into the center. Signal the left wing to advance. Push their forces inward. Keep the pressure constant. We will break them!''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 3
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        textToSpeak = "''Now, the final push. Forward! Drive them into the ground!''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        cheer2Sound.Play();
        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        //the event position becomes 3
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //event 5
        nextButton.SetActive(false);
        charNameRight.SetActive(false);
        textToSpeak = "The Byzantine forces overpower the remaining Vandals, cutting through them with relentless precision as they press their advance. The Vandals, overwhelmed and outmatched, are forced into a desperate retreat, their ranks shattered and spirits crushed.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 3
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //event 6
        nextButton.SetActive(false);
        charBelisarius.SetActive(false);
        textToSpeak = "The battle is lost. Your breathing is heavy, your body aching from wounds and exhaustion. Suddenly, you see a Byzantine patrol coming toward your direction...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        choiceLeftButton.SetActive(true);
        choiceRightButton.SetActive(true);
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
            default:
                Debug.Log("Event not found");
                break;
        }
    }
    
    public void LeftChoice()
    {
        SceneManager.LoadScene(5);
    }

    public void RightChoice()
    {
        StartCoroutine(LoadRightChoice());
    }

    IEnumerator LoadRightChoice()
    {
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(6);
    }
}
