using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f;                    //탄알 이동 속력
    private Rigidbody BulletRigidbody;            //이동에 사용할 리지드바디 컴포넌트  


    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigidbidy 컴포넌트를 찾아서 BulletRigidbody에 할당
        BulletRigidbody = GetComponent<Rigidbody>();

        //리지드바디의 속도 = 앞쪽 방향 * 이동속력 transform.forward 는 z축 앞쪽 방향을 이야기한다.
        BulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);

    }

    //트리거 충돌 시 자동으로 실행되는 매서드
    private void OnTriggerEnter(Collider other)               //충돌한 게임 오브젝트 콜라이더 (other)
    {    
        //충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if(other.tag == "Player")
        {
            //상대방 게임 오브젝트에서 PlayerController 컴포넌트를 가져온다.
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
                playerController.Die();
            }
        }
    }

    //private void nCollisionEnter(Collision collision)
    //{

    //    //충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        //상대방 게임 오브젝트에서 PlayerController 컴포넌트를 가져온다.
    //        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

    //        if (playerController != null)
    //        {
    //            playerController.Die();
    //        }
    //    }
    //}
}
