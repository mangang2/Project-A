using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f;                    //ź�� �̵� �ӷ�
    private Rigidbody BulletRigidbody;            //�̵��� ����� ������ٵ� ������Ʈ  


    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbidy ������Ʈ�� ã�Ƽ� BulletRigidbody�� �Ҵ�
        BulletRigidbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���� ���� * �̵��ӷ� transform.forward �� z�� ���� ������ �̾߱��Ѵ�.
        BulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);

    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �ż���
    private void OnTriggerEnter(Collider other)               //�浹�� ���� ������Ʈ �ݶ��̴� (other)
    {    
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if(other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ�� �����´�.
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
                playerController.Die();
            }
        }
    }

    //private void nCollisionEnter(Collision collision)
    //{

    //    //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        //���� ���� ������Ʈ���� PlayerController ������Ʈ�� �����´�.
    //        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

    //        if (playerController != null)
    //        {
    //            playerController.Die();
    //        }
    //    }
    //}
}
