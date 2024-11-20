using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene00Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charIsabel;
    public GameObject charMedallion;
    public GameObject textBox;
    [SerializeField] GameObject charNameLeft;
    [SerializeField] GameObject charNameRight;

    [SerializeField] AudioSource surpriseSound;
    [SerializeField] AudioSource timeTravelSound;

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
        fadeScreenOut.SetActive(false);
        charNameRight.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeScreenIn.SetActive(true);
        charNameRight.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        yield return new WaitForSeconds(2);
        exitButton.SetActive(true);
        charNameLeft.SetActive(false);
        textToSpeak = "Time has passed, but the earth holds secrets. Carthago, once a mighty city, now lies in ruin. Yet, history waits to be uncovered, and sometimes... it finds you first.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        mainTextObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 1
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        // event 1
        nextButton.SetActive(false);
        textToSpeak = "Isabel Reyes, a renowned archaeologist from Princeton, has spent years chasing the mysteries of ancient civilizations. Her latest obsession: uncovering the long-lost secrets of the Vandal Kingdom.";
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
        charIsabel.SetActive(true);
        charNameLeft.SetActive(true);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Isabel Reyes";
        textToSpeak = "''The Vandals ruled here for nearly a century, and yet we know so little about them. Everyone focuses on the Roman ruins, but I know there’s something more beneath all this dust… something that could finally tell their story.''";
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
        mainTextObject.SetActive(true);
        textToSpeak = "''Carthage must still be hiding something… something that ties all the pieces together. I can feel it. \nWait… what is this?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        surpriseSound.Play();
        nextButton.SetActive(true);
        //the event position becomes 3
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        charNameLeft.SetActive(false);
        charIsabel.SetActive(false);
        charMedallion.SetActive(true);
        textToSpeak = "Isabel brushes away more dirt, revealing a small, intricately carved object—a pendant or medallion etched with symbols of Vandalic origin. Her eyes widen with realization.";
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
        nextButton.SetActive(false);
        charNameLeft.SetActive(true);
        textToSpeak = "''An artifact from the Vandals? But how could it have remained hidden for so long? It's remarkably preserved…''";
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
        charNameLeft.SetActive(false);
        textToSpeak = "She carefully lifts the object in her hand, the weight of history heavy upon her. Suddenly, her vision blurs and the world around her begins to shift and distort. Sounds of ancient battle, clashing swords, and the distant cries of warriors echo in their ears.";
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
        charNameLeft.SetActive(false);
        textToSpeak = "In an instant, the archaeologist is transported—not in body, but in mind—into the distant past. Through the eyes of a Vandal warrior, they witness the final days of the kingdom.";
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
        timeTravelSound.Play();
        nextButton.SetActive(false);
        exitButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(2);
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
            default:
                Debug.Log("Event not found");
                break;
        }
    }
}
