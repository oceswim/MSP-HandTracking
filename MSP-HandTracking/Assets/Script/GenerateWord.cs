using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateWord : MonoBehaviour
{
    public TMP_Text englishWord;
    public TMP_Text frenchWord;
    public Material frameTexture;
    public Texture[] wordPicture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateAWord()
    {
        englishWord.text = "Dog";
        frenchWord.text = "Chien";
        frameTexture.SetTexture("_MainTex", wordPicture[0]);
    }
}
