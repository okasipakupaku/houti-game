using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaGameManager : MonoBehaviour
{
    public const int Wall_GachaHome = 1;
    public const int Wall_Weapons = 2;
    public const int Wall_Equipments = 3;
    public const int Wall_Accessories = 4;
    public const int Wall_Ornaments = 5;

    public GameObject gachaWalls;

    public GameObject WGB;//武器ガチャボタン
    public GameObject EGB;
    public GameObject AGB;
    public GameObject OGB;

    private int wallNo;

    // Start is called before the first frame update
    void Start()
    {
        wallNo = Wall_GachaHome;
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
            case Wall_GachaHome:
                gachaWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case Wall_Weapons://武器ガチャウィンドウ表示
                gachaWalls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;

            case Wall_Equipments://装備ガチャウィンドウ表示
                gachaWalls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;

            case Wall_Accessories://アクセサリーガチャウィンドウ表示
                gachaWalls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;

            case Wall_Ornaments://宝石ガチャ表示
                gachaWalls.transform.localPosition = new Vector3(-4000.0f, 0.0f, 0.0f);
                break;
        }
    }

}
