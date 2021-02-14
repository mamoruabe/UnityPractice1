using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDataFetcher : MonoBehaviour
{
	public Text resultMessageText;
    // Start is called before the first frame update
    void Start()
    {
        resultMessageText.text = DataSendar.resultMessage;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
        	SceneManager.LoadScene("title 1");
        }
    }
}
