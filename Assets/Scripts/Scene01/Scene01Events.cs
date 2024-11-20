using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject carthageMemories;
    public GameObject charGuntharic;
    public GameObject charBerimund;
    public GameObject textBox;
    [SerializeField] GameObject Title;
    [SerializeField] GameObject charNameLeft;
    [SerializeField] GameObject charNameRight;

    [SerializeField] AudioSource birdsSound;
    [SerializeField] AudioSource kidsPlaying;

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
        Title.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeScreenIn.SetActive(true);
        fadeScreenOut.SetActive(false);
        Title.SetActive(false);
        yield return new WaitForSeconds(2);
        birdsSound.Play();
        mainTextObject.SetActive(true);
        exitButton.SetActive(true);
        charNameRight.SetActive(false);
        charNameLeft.SetActive(false);
        textToSpeak = "Once, the Vandals were wanderers, a people displaced and scattered across the fading Western Roman Empire. From the forests of Germania, they moved south, crossing the frozen rivers and the mountains in search of a home.";
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
        textToSpeak = "They clashed with Romans and Goths alike, but it was across the sea, in the rich lands of North Africa, that their destiny was written. Led by their cunning king Gaiseric, the Vandals crossed the Mediterranean, seizing Carthago and the fertile lands of Africa from Roman hands.";
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
        textToSpeak = "For nearly a century, they ruled here, building a kingdom from the ashes of the empire that once held them at bay. But now, the Byzantines come to reclaim what they believe is theirs.";
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
        charGuntharic.SetActive(true);
        charNameLeft.SetActive(true);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        textToSpeak = "''I have fought many battles, but this one feels different. They say Belisarius never loses. His soldiers are disciplined, and their ambition knows no bounds. But I cannot show fear. To my brothers, to my people... I must be strong.''";
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
        charNameLeft.SetActive(false);
        textBox.SetActive(true);
        charBerimund.SetActive(true);
        charNameRight.SetActive(true);
        charNameRight.GetComponentInChildren<TMPro.TMP_Text>().text = "Berimund";
        textToSpeak = "''You look worried today... I'm not used to see you like that, Guntharic. You don't think we'll win?''";
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
        charNameRight.SetActive(false);
        charNameLeft.SetActive(true);       
        textToSpeak = "''I've fought enough battles to know when an enemy shouldn't be underestimated. The Byzantines aren't like the Romans we faced before. They come with their strategists, their endless gold... and they won't stop until they take everything from us''";
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
        charNameRight.SetActive(true);
        textToSpeak = "''They may have numbers, but we have fire. We are warriors, and this is our home. We won't let them take it easily.''";
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
        charNameRight.SetActive(false);
        charNameLeft.SetActive(true);       
        textToSpeak = "''Perhaps... but fire can be extinguished. We must be more than that. We must be unbreakable.''";
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
        mainTextObject.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeScreenOut.SetActive(false);
        carthageMemories.SetActive(true);
        fadeScreenIn.SetActive(true);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        charNameLeft.SetActive(true);
        kidsPlaying.Play();
        textToSpeak = "''Once, I knew only peace. My father spoke of battles fought in distant lands, but to me, this city was a haven. Now, I stand on the precipice of war, fighting to preserve the only life I've ever known.''";
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
        eventPos = 9;
    }

    IEnumerator EventNine()
    {
        //event 9
        nextButton.SetActive(false);
        mainTextObject.SetActive(false);
        charNameRight.SetActive(false);
        charNameLeft.SetActive(false); 
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeScreenOut.SetActive(false);
        carthageMemories.SetActive(false);
        fadeScreenIn.SetActive(true);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        charNameLeft.SetActive(true); 
        textToSpeak = "''The time is near. The Byzantines won't wait forever. We need to get ready for the battle...''";
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
        fadeScreenIn.SetActive(false);
        nextButton.SetActive(false);
        exitButton.SetActive(false);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
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
            default:
                Debug.Log("Event not found");
                break;
        }
    }
}
