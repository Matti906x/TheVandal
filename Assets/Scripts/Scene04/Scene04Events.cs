using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene04Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charGuntharic;
    public GameObject textBox;
    [SerializeField] GameObject charNameLeft;
    [SerializeField] GameObject charNameRight;
    [SerializeField] GameObject badEndingCanvas;

    [SerializeField] AudioSource clashSound;
    [SerializeField] AudioSource shoutSound;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject exitButton;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject menuButton;
    [SerializeField] GameObject quitButton;
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
        textToSpeak = "You tighten your grip on your sword, watching as a group of Byzantine soldiers march toward you and your comrades. Your body is battered, but your spirit remains unbroken.";
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
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        //event 1
        nextButton.SetActive(false);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        charNameLeft.SetActive(true);
        textToSpeak = "''Everything is gone. Our city... our people... broken. But I will not run. Not while I still draw breath.''";
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
        charNameLeft.SetActive(false);
        textToSpeak = "The Vandal warriors fight with everything they have left, deflecting strikes, dodging, and countering with powerful, desperate swings, but they start falling one after the other.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        clashSound.Play();
        yield return new WaitForSeconds(1.5f);
        nextButton.SetActive(true);
        //the event position becomes 3
        eventPos = 3;
    }
    
    IEnumerator EventThree()
    {
        // event 3
        nextButton.SetActive(false);
        nextButton.SetActive(false);
        textToSpeak = "You take down one more Byzantine soldier, but your movements are slowing, your strength fading. You see many more enemies coming toward you.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        clashSound.Play();
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 4
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        charNameLeft.SetActive(true);
        textToSpeak = "''Come on! Is that all you have?! I won't stop... not yet... I can still fight...''";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 5
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //event 5
        nextButton.SetActive(false);
        charNameLeft.SetActive(false);
        textToSpeak = "You swing your sword one last time, catching a glimpse of your enemies rushing toward you. A spear strikes you in the chest as your body crumples to the ground";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        clashSound.Stop();
        shoutSound.Play();
        yield return new WaitForSeconds(1.5f);
        nextButton.SetActive(true);
        //the event position becomes 6
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //event 6
        nextButton.SetActive(false);
        charGuntharic.SetActive(false);
        textToSpeak = "In the end, you fought until your last breath. Though your body lies still, your spirit lives on in the memory of the fallen.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 5
        eventPos = 7;
    }

    IEnumerator EventSeven()
    {
        //event 7
        nextButton.SetActive(false);
        textBox.SetActive(false);
        exitButton.SetActive(false);
        fadeScreenIn.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        badEndingCanvas.SetActive(true);
        fadeScreenIn.SetActive(true);
        fadeScreenOut.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        menuButton.SetActive(true);
        quitButton.SetActive(true);
        //the event position becomes 5
        eventPos = 7;
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
                badEndingCanvas.SetActive(true);
                break;
            default:
                Debug.Log("Event not found");
                break;
        }
    }
}
