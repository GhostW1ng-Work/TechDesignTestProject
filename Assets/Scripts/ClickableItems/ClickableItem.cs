using UnityEngine;

[RequireComponent(typeof(Animator), typeof(AudioSource))]
public class ClickableItem : MonoBehaviour
{
	private const string PLAY = "Play";

	[SerializeField] private int _minPitch = 1;
	[SerializeField] private int _maxPitch = 4;
	[SerializeField] private ParticleSystem _particles;
	[SerializeField] private Texture2D _cursorHover;

	private Vector2 _hotspot;
	private Texture2D _defaultCursor;
	private AudioSource _audioSource;
	private Animator _animator;

	private void Start()
	{
		_defaultCursor = null;
		_hotspot = Vector2.zero;
		_audioSource = GetComponent<AudioSource>();
		_animator = GetComponent<Animator>();
	}

	private void OnMouseEnter()
	{
		Cursor.SetCursor(_cursorHover, _hotspot, CursorMode.Auto);
	}

	private void OnMouseExit()
	{
		Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.Auto);
	}

	private void OnMouseDown()
	{
		if(_animator != null)
		{
			_animator.SetTrigger(PLAY);
		} 

		if(_audioSource.clip != null)
		{
			int randomPitch = Random.Range(_minPitch, _maxPitch);
			_audioSource.pitch = randomPitch;
			_audioSource.Play();
		}

		if(_particles != null)
		{
			_particles.Play();
		}
	}

}
