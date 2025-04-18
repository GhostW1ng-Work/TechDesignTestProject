using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class CloudMover : MonoBehaviour
{
	[SerializeField] private float _minSpeed = 0.5f;
	[SerializeField] private float _maxSpeed = 2f;

	[SerializeField] private float _leftEdgeX = -10f;
	[SerializeField] private float _rightEdgeX = 10f;

	private float _currentSpeed;
	private Vector3 _direction;
	private SpriteRenderer _spriteRenderer;

	void Start()
	{
		_spriteRenderer = GetComponent<SpriteRenderer>();
		ResetCloud();
	}

	void Update()
	{
		transform.Translate(_direction * _currentSpeed * Time.deltaTime);

		if (_direction.x > 0 && transform.position.x > _rightEdgeX ||
			_direction.x < 0 && transform.position.x < _leftEdgeX)
		{
			ResetCloud();
		}
	}

	void ResetCloud()
	{
		bool spawnFromLeft = Random.value < 0.5f;

		float spawnX = spawnFromLeft ? _leftEdgeX : _rightEdgeX;
		_direction = spawnFromLeft ? Vector3.right : Vector3.left;

		transform.position = new Vector3(spawnX, transform.position.y, transform.position.z);

		_currentSpeed = Random.Range(_minSpeed, _maxSpeed);

		if (_spriteRenderer != null)
		{
			_spriteRenderer.flipX = !spawnFromLeft;
		}
	}
}
