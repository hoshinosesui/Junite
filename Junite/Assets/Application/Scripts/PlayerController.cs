using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    //入力用変数
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
        //入力を受ける
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //前後移動のアニメーション
        animator.SetFloat("Speed", verticalInput);

        //前後移動
        //後ろに移動する際には移動速度が半分
        if(verticalInput >= -0.5)
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
}
