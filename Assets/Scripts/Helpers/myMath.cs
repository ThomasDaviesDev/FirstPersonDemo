using UnityEngine;
using System.Collections;

public static class myMath {

	public static float ClampAngle(float angle, float min, float max)
	{
		angle = NormalizeAngle(angle);
		if (angle > 180)
		{
			angle -= 360;
		}
		else if (angle < -180)
		{
			angle += 360;
		}

		min = NormalizeAngle(min);
		if (min > 180)
		{
			min -= 360;
		}
		else if (min < -180)
		{
			min += 360;
		}

		max = NormalizeAngle(max);
		if (max > 180)
		{
			max -= 360;
		}
		else if (max < -180)
		{
			max += 360;
		}

		angle = Mathf.Clamp(angle, min, max);

		return angle;
	}

	public static float NormalizeAngle(float angle)
	{
		while (angle > 360)
			angle -= 360;
		while (angle < 0)
			angle += 360;

		return angle;
	}

	public static Vector3 ClampVelocity(Vector3 velocity, float maxSpeed)
	{
		Vector3 normalizedVelocity = velocity.normalized;
		float magnitudeVelocity = velocity.magnitude;

		if(magnitudeVelocity > maxSpeed)
		{
			velocity = normalizedVelocity * maxSpeed;
		}

		return velocity;
	}

}
