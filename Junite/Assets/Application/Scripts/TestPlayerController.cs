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

    //���͗p�ϐ�
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
        //���͂��󂯂�
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //�O��ړ��̃A�j���[�V����
        animator.SetFloat("Speed", verticalInput);

        //�O��ړ�
        //���Ɉړ�����ۂɂ͈ړ����x������
        if (verticalInput >= -0.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        }
        else if (verticalInput < -0.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput * 0.5f);
        }

        //���E�ړ�
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput);
    }

    private void Attack()
    {
        //�p���`
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
