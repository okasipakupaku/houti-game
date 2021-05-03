using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaGameManager : MonoBehaviour
{
    public GameObject gachaWalls;

    private int wallNo;

    // Start is called before the first frame update
    void Start()
    {
        wallNo = 1;
        DisplayGacha();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushButtonWeapons()//武器ガチャ画面表示
    {
        wallNo = 2;

        DisplayGacha();

    }

    public void PushButtonEquipments()
    {
        wallNo = 3;
        DisplayGacha();

    }

    public void PushButtonAccessories()
    {
        wallNo = 4;
        DisplayGacha();
    }

    public void PushButtonOrnaments()
    {
        wallNo = 5;
        DisplayGacha();
    }

    public void PushBackGachaHome()//ガチャホームにもどる
    {
        wallNo = 1;
        DisplayGacha();
    }



    void DisplayGacha()
    {
        switch (wallNo)
        {
            case 1://ガチャホームに戻る
                gachaWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case 2://武器ガチャウィンドウ表示
                gachaWalls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;

            case 3://装備ガチャウィンドウ表示
                gachaWalls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;

            case 4://アクセサリーガチャウィンドウ表示
                gachaWalls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;

            case 5://宝石ガチャ表示
                gachaWalls.transform.localPosition = new Vector3(-4000.0f, 0.0f, 0.0f);
                break;
        }
    }

}
