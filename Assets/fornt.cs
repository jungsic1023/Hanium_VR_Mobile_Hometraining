using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickExample : MonoBehaviour
{
    public Button yourButton;
    private Rigidbody rigid;
    private float walkSpeed = 20;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        rigid = GetComponent<Rigidbody>();
    }

    void TaskOnClick()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        Vector3 moveHorizontal = transform.right * moveX;

        Vector3 _velocity = (moveHorizontal).normalized * walkSpeed;

        rigid.MovePosition(transform.position + _velocity * Time.deltaTime);

    }
}