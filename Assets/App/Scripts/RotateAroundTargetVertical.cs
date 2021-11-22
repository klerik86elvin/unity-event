using UnityEngine;

namespace DynamicBox.ArcheryGame
{
	public class RotateAroundTargetVertical : MonoBehaviour
	{
		[SerializeField] private Transform target;

		[SerializeField] private float editor_rotate_speed = 60;
		[SerializeField] private float maxValue = 50;
		[SerializeField] private float minValue = 5;

		private float rotateOffset;

		void LateUpdate()
		{
			rotateOffset = Input.GetAxis("Mouse Y") * -1 * editor_rotate_speed * Time.deltaTime;
			CameraArithmetic(rotateOffset);
		}

		private void CameraArithmetic(float vertical)
		{

			bool lookFromUp = Vector3.Angle(transform.forward, target.transform.up * -1) > Vector3.Angle(transform.forward, target.transform.up);

			transform.RotateAround(target.position, transform.right, vertical);

			float forwardAngle = Vector3.Angle(target.transform.forward, transform.forward);

			if (lookFromUp)
			{
				if (forwardAngle > minValue)
				{
					transform.RotateAround(target.position, transform.right, forwardAngle - minValue);
				}
			}
			else
			{
				if (forwardAngle > maxValue)
				{
					transform.RotateAround(target.position, transform.right, maxValue - forwardAngle);
				}
			}
		}
	}
}