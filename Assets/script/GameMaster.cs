using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMaster : MonoBehaviour
{
	public int boxNum;
    public float nowTime;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if (boxNum <= 0 || Input.GetKey(KeyCode.C) ) {
            GameOver(nowTime.ToString("F0") + "秒でクリアできた！");
        }
    }
    public void GameOver(string resultMessage) {
        DataSendar.resultMessage = resultMessage;
        SceneManager.LoadScene("result");
    }
}
