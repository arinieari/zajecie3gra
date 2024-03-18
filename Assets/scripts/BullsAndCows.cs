using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BullsAndCows : MonoBehaviour
{
    public TextMeshProUGUI textSecretWord;
    public TextMeshProUGUI textSecretWordLength;
    public TextMeshProUGUI textLivesCount;
    public string secretWord = "hello";
    public int playerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        textSecretWord.text = "The secret word is [" + secretWord + "]";
        textSecretWordLength.text = "The lenth of secret word is " + secretWord.Length;
        textLivesCount.text = "You have " + playerLives + " lives left";



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick (TMP_InputField input)
    {
        if (playerLives <= 0)
        {
            return;
        }
        if (input.text == secretWord)
        {
            Win();
            return;
        }
        if (secretWord.Length != input.text.Length)
        {
            RemoveLife();
            Debug.Log("Wrong length, try again");
            textSecretWord.text = "Wrong length! Try again and press Submit!";

        }
        else
        {
            RemoveLife();
            int bulls = CountBulls(secretWord, input.text);

            textSecretWord.text = "Bulls: " + bulls + "Cows: " + BullsAndCows + "Try again and press enter";
        }
        Debug.Log("Input was: " + input.text);
        if (secretWord.Length != input.text.Length)
        {
            Debug.Log("Wrong lenth, try again");
        }
        input.text = "";

    }
}
