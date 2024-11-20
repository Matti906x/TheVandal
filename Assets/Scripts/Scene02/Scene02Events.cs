using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene02Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charGuntharic;
    public GameObject charSigisvult;
    public GameObject textBox;
    [SerializeField] GameObject charNameLeft;
    [SerializeField] GameObject charNameRight;

    [SerializeField] AudioSource cheerSound;
    [SerializeField] AudioSource areYouReadySound;

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
        fadeScreenIn.SetActive(true);
        fadeScreenOut.SetActive(false);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        exitButton.SetActive(true);
        charSigisvult.SetActive(true);
        charNameRight.GetComponentInChildren<TMPro.TMP_Text>().text = "General Sigisvult";
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Vandalic Military Camp";
        textToSpeak = "''Brothers! Sons of Carthago! Today is not a day for fear. Today is a day for glory! he Byzantines come to take what we have bled for! They think they will crush us with their numbers, with their 'great general' Belisarius. But numbers do not win battles! Strength of heart does!''";
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
        charNameLeft.SetActive(false);
        textToSpeak = "''Look around you! The men standing at your side are your brothers! Your fathers! Your sons! We fight not for the whims of some distant emperor, but for our homes, our families, our very lives!''";
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
        textToSpeak = "''You, my warriors, are lions! And today, we will show them that even an empire cannot break the spirit of the free! We will show them that the Vandals do not bow to kings—they are kings!''";
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
        textToSpeak = "''Carthage is ours! Africa is ours! And we will not give it up without a fight they will remember for a thousand years!''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        areYouReadySound.Play();
        yield return new WaitForSeconds(1);
        cheerSound.Play();
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 3
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        charSigisvult.SetActive(false);
        charNameRight.SetActive(false);
        charGuntharic.SetActive(true);
        charNameLeft.SetActive(true);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        textToSpeak = "''The Byzantines come with steel and ambition... but we have fire. We fight for more than they could ever understand.''";
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
        fadeScreenIn.SetActive(false);
        nextButton.SetActive(false);
        exitButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
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
            default:
                Debug.Log("Event not found");
                break;
        }
    }
}
