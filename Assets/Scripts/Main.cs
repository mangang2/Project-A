using UnityEngine;

public class Main : MonoBehaviour
{
    public int gold = 1000;     //변수(정수) gold(변수 이름) 선언하고 1000값을 넣어줌
    public float itemWeight = 1.34f;     //float(실수) itemWeight(변수 이름) 선언하고 1.34값을 넣어줌
    public bool isStoreOpen = true;      //bool (참/거짓) isStoreOpen(변수 이름) 선언하고 true값을 넣어줌
    public string itemName = "포션";       //string(문자열) itemName(변수 이름) 선언하고 포션(문자열)을 넣어줌

    public int HP = 100;      //체력값 선언
    public float MoveDistance = 0.0f;     //이동 값 선언

    public void Move(int hp , int distance)  //이동 함수 선언
    {
        HP = HP - hp;      //함수 hp 인수 받은 만큼 감소
        MoveDistance = MoveDistance + distance;      //함수 distance 인수 받은 만큼 감소
    }

    public int RandomNumber()
    {
        int Number = 0;
        Number = Random.Range(0, 10);

        return Number;
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Gold : " + gold + " itemWeight : " + itemWeight
            + " isStoreOpen : " + isStoreOpen + " itemName : " + itemName);
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(KeyCode.Alpha1.ToString() + " 버튼 눌림 ");
            Move(0 , 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(KeyCode.Alpha2.ToString() + " 버튼 눌림 ");
            Move(30 , 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(KeyCode.Alpha3.ToString() + " 버튼 눌림 ");
            Move(15 , 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))     //4번 버튼을 눌렀을때
        {
            int GetRandNumber = 0;
            GetRandNumber = RandomNumber();
            Debug.Log(" GetRandNumeber  : " + GetRandNumber);
        }


    }   
}


