csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public float moveSpeed = 5f;

void Update()
{

float xInput = Input.GetAxis("Horizontal");
float zInput = Input.GetAxis("Vertical");

Vector3 moveDirection = new Vector3(xInput, 0, zInput) * moveSpeed * Time.deltaTime;

transform.Translate(moveDirection);
}
}
