using UnityEngine;

public class AnimatorSpeedRandomizer : MonoBehaviour
{
	[SerializeField] private float _minSpeed = 0.9f;
	[SerializeField] private float _maxSpeed = 1.2f;

	private Animator _animator;

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	private void Start()
	{
		_animator.speed = Random.Range(_minSpeed, _maxSpeed);
	}
}
