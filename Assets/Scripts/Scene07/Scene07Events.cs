using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene07Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charGuntharic;
    public GameObject textBox;
    [SerializeField] GameObject charNameLeft;
    [SerializeField] GameObject badEndingCanvas;
    [SerializeField] GameObject minesCanvas;
    [SerializeField] GameObject menuButton;
    [SerializeField] GameObject quitButton;

    [SerializeField] AudioSource miningSound;

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
        mainTextObject.SetActive(true);
        charNameLeft.SetActive(false);
        textToSpeak = "You continue to walk, the pull of the chains on your wrists a constant reminder of your new life. Each step drags you farther from the world you once knew, from the land you once fought to protect.";
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
        textToSpeak = "The others march in silence, their faces hollow, eyes fixed ahead as if they, too, have accepted their fate.";
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
        textToSpeak = "After many days of walk, the path dips into shadow as you near a dark cavern yawning in the mountainside. The air is thick with dust, and the stench of damp earth fills your lungs.";
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
        miningSound.Play();
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        minesCanvas.SetActive(true);
        fadeScreenOut.SetActive(false);
        fadeScreenIn.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        textToSpeak = "The sounds of picks against stone echo from within, a rhythm of relentless labor. You understand you've been sent to the worst place ever, the mines.";
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
        textToSpeak = "You descend into the mine, your feet crunching against loose gravel, the light from outside fading until you are swallowed by the shadows. The clinking of chains, the rasp of labored breaths, the ceaseless clatter of picks striking stone—they are the sounds that will haunt you from now on.";
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
        textToSpeak = "The guards push you deeper, past hunched figures whose faces are obscured in the dim light. You catch glimpses of eyes glazed with exhaustion, hands calloused and raw. These men are ghosts, shadows of who they once were, and soon, you know, you will become one of them.";
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
        textToSpeak = "They thrust a rough wooden handle into your hands, the iron blade heavy at the end. You grip it, feeling its weight. The life you led, the freedom you once tasted, seems to fade as you raise the pick and bring it down against the stone.";
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
        charGuntharic.SetActive(true);
        charNameLeft.GetComponentInChildren<TMPro.TMP_Text>().text = "Guntharic";
        charNameLeft.SetActive(true);
        textToSpeak = "''This will be my life. A steady rhythm of stone and silence, a life without sunlight. But I will endure. For as long as I can, I will remember… even as the world forgets.''";
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
        charNameLeft.SetActive(false);
        textToSpeak = "You settle into the rhythm, each swing a mark of passing time. The darkness presses in, the air thick with dust, the faint scent of earth all around you.";
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
        textToSpeak = "Days, months, even years blur together as you toil, the fire of battle long extinguished. You lose track of time, yet somewhere deep within, you hold a spark—a memory of who you were.";
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
        textToSpeak = "But slowly, as years grind on, even that spark fades. The world above carries on without you, but here, in the silent depths of the earth, your story ends, lost to time.";
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
        //event 12
        charGuntharic.SetActive(false);
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
