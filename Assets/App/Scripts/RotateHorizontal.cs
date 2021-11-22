using UnityEngine;
namespace DynamicBox.ArcheryGame
{
	public class RotateHorizontal : MonoBehaviour
	{
		[SerializeField] float rotateSpeed = 70;


		void LateUpdate()
		{ 
			float horizontalInput = Input.GetAxis("Mouse X");
			transform.Rotate(Vector3.up, horizontalInput * rotateSpeed * Time.deltaTime);
		}
	}
}