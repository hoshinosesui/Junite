using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    //���͗p�ϐ�
    private float verticalInput;
    private float horizontalInput;

    public float moveSpeed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //���͂��󂯂�
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //�O��ړ��̃A�j���[�V����
        animator.SetFloat("Speed", verticalInput);

        //�O��ړ�
        //���Ɉړ�����ۂɂ͈ړ����x������
        if(verticalInput >= -0.5)
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
}
