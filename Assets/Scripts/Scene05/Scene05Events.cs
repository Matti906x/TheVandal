using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene05Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject charGuntharic;
    public GameObject textBox;
    [SerializeField] GameObject charNameLeft;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject exitButton;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject leftChoiceButton;
    [SerializeField] GameObject rightCohiceButton;
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
        fadeScreenIn.SetActive(true);
        yield return new WaitForSeconds(2);
        exitButton.SetActive(true);
        charGuntharic.SetActive(true);
        mainTextObject.SetActive(true);
        charNameLeft.SetActive(false);
        textToSpeak = "You stand in the middle of the battlefield, surrounded by the ruins of your people's last stand. The sounds of battle have faded—now, only the groans of the wounded and the soft clink of armor remain.";
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
        //event 1
        nextButton.SetActive(false);
        textToSpeak = "You look down at your sword, its blade chipped and stained. There's no more strength left in you to lift it. No more fight left in your heart. Slowly, painfully, you lower your weapon. The tip of your sword touches the ground, and you let go. It falls with a soft thud, swallowed by the dirt.";
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
        textToSpeak = "You raise your hands in a gesture of surrender. Your vision blurs, but you keep your gaze steady, facing the approaching soldiers. The captain approaches, standing directly in front of you. You expect him to cut you down, to end it here. But instead, he gestures to his men to bind your hands.";
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
        eventPos = 3;
    }
    
    IEnumerator EventThree()
    {
        // event 3
        nextButton.SetActive(false);
        textToSpeak = "You feel the rough rope bite into your wrists as the soldiers tie your hands behind your back. Your heart races, but you make no attempt to resist. A strange calm settles over you—perhaps this is what survival feels like, even if it is not the victory you once dreamed of.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        //the event position becomes 4
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        textToSpeak = "You walk, hands bound, escorted by Byzantine soldiers through a desolate road. You can feel the eyes of the soldiers on you, watching your every move. The rope bites into your wrists, but your mind is racing, searching for an opening.";
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
        textToSpeak = "The path curves ahead, thick with trees and rocks. The shadows grow longer as dusk approaches, and the terrain becomes more rugged. You notice the soldiers' focus slipping, distracted by their weariness and the fading light.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(1.5f);
        nextButton.SetActive(true);
        //the event position becomes 6
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //event 6
        charGuntharic.SetActive(false);
        nextButton.SetActive(false);
        textToSpeak = "As you near a dense patch of forest, the sound of waves faintly reaches your ears. A small port must be nearby. A plan forms in your mind—a desperate one, will you take the risk?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        //if textlenght = currenttextlenght the whole text has been run
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);
        leftChoiceButton.SetActive(true);
        rightCohiceButton.SetActive(true);
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
            default:
                Debug.Log("Event not found");
                break;
        }
    }

    public void LeftChoice()
    {
        SceneManager.LoadScene(7);
    }

    public void RightChoice()
    {
        SceneManager.LoadScene(8);
    }
}
