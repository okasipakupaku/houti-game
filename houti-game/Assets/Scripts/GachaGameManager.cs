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

    public void PushButtonWeapons()//����K�`����ʕ\��
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

    public void PushBackGachaHome()//�K�`���z�[���ɂ��ǂ�
    {
        wallNo = 1;
        DisplayGacha();
    }



    void DisplayGacha()
    {
        switch (wallNo)
        {
            case 1://�K�`���z�[���ɖ߂�
                gachaWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case 2://����K�`���E�B���h�E�\��
                gachaWalls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;

            case 3://�����K�`���E�B���h�E�\��
                gachaWalls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;

            case 4://�A�N�Z�T���[�K�`���E�B���h�E�\��
                gachaWalls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;

            case 5://��΃K�`���\��
                gachaWalls.transform.localPosition = new Vector3(-4000.0f, 0.0f, 0.0f);
                break;
        }
    }

}
