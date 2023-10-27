using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public DateTime CurrentTime => currentTime;

	public UnityEvent<float> OnTimeUpdated;

	[SerializeField] float timeSpeed = 1.0f;
	[SerializeField] UDateTime startTime;

	[SerializeField] UDateTime endTime;

	private DateTime currentTime;

	public bool IsTimeStopped { get; private set; }

	private void Awake()
	{
		currentTime = startTime.dateTime;
		IsTimeStopped = false;
	}

	private void Update()
	{
		if (!ShouldUpdateTime()) {
			return;
		}

		float deltaTime = Time.deltaTime * timeSpeed;
		currentTime = currentTime.AddSeconds(Time.deltaTime * timeSpeed);
		OnTimeUpdated?.Invoke(deltaTime);

		if ((endTime - currentTime).TotalMilliseconds <= 0) {
		   Debug.LogError("Es gibt nichts");
		}
	}

	private bool ShouldUpdateTime()
	{
		return
			!IsTimeStopped;
	}

	public void StopTime()
	{
		IsTimeStopped = true;
	}

	public void ContinueTime()
	{
		IsTimeStopped = false;
	}

	public void AddTime(float seconds)
	{
		currentTime = currentTime.AddSeconds(seconds);
		OnTimeUpdated?.Invoke(seconds);
	}
}
