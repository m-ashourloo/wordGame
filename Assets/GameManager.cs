using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float backgroundSpeed = 2f;
    [SerializeField] SpriteRenderer firstBackground;
    [SerializeField] SpriteRenderer secondBackground;


    private TouchScreenKeyboard keyboard;


    private void OnGUI()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    // Update is called once per frame
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
