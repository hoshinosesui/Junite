using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestPlayerController : MonoBehaviour
{
    private Animator animator;
    private Collider handCollider;
    private NavMeshAgent agent;
    private bool isPunching;

    //入力用変数
    private float verticalInput;
    private float horizontalInput;

    public float moveSpeed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        handCollider = GameObject.Find("B-hand_R").GetComponent<BoxCollider>();
        agent = GetComponent<NavMeshAgent>();

        isPunching = animator.GetBool("Punch");
    }

    // Update is called once per frame
    void Update()
    {
        Locomotion();
        Attack();
    }

    private void Locomotion()
    {
        //入力を受ける
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //前後移動のアニメーション
        animator.SetFloat("Speed", verticalInput);

        //前後移動
        //後ろに移動する際には移動速度が半分
        if (verticalInput >= -0.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        }
        else if (verticalInput < -0.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput * 0.5f);
        }

        //左右移動
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput);
    }

    private void Attack()
    {
        //パンチ
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("Punch", true);
            handCollider.enabled = true;
        }
        else
        {
            animator.SetBool("Punch", false);
            handCollider.enabled = false;
        }
    }
}
