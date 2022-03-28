using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordGameManager : MonoBehaviour
{
    [SerializeField] float backgroundSpeed = 2f;
    [SerializeField] SpriteRenderer firstBackground;
    [SerializeField] SpriteRenderer secondBackground;
    [SerializeField] TextMeshProUGUI outputTextMesh;
    string letters = "";



    private TouchScreenKeyboard keyboard;


    private void Start()
    {
    }

    private void Update()
    {
        foreach (char letter in Input.inputString)
        {
            letters += letter;
            Debug.Log(letters);
            outputTextMesh.SetText(Fa.faConvert( letters));
        }
    }

    void FixedUpdate()
    {
        MoveBackgrounds();
        CheckBackgroundsPosition();
    }

    void MoveBackgrounds()
    {
        firstBackground.transform.Translate(new Vector2(0,-1f) * backgroundSpeed * Time.deltaTime);
        secondBackground.transform.Translate(new Vector2(0, -1f) * backgroundSpeed * Time.deltaTime);
    }

    void CheckBackgroundsPosition()
    {
        if(firstBackground.transform.position.y <= -firstBackground.bounds.size.y)
        {
            firstBackground.transform.position = new Vector3(0, 1f * firstBackground.bounds.size.y - 0.2f, 0);
        }
        if (secondBackground.transform.position.y <= -secondBackground.bounds.size.y)
        {
            secondBackground.transform.position = new Vector3(0, 1f * secondBackground.bounds.size.y - 0.2f, 0);
        }
    }
}
