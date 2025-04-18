using UnityEngine;

[RequireComponent(typeof(Animator), typeof(AudioSource))]
public class ClickableItem : MonoBehaviour
{
	private const string PLAY = "Play";

	[SerializeField] private ParticleSystem _particles;

	private AudioSource _audioSource;
	private Animator _animator;

	private void Start()
	{
		_audioSource = GetComponent<AudioSource>();
		_animator = GetComponent<Animator>();
	}

	private void OnMouseDown()
	{
		if(_animator != null)
		{
			_animator.SetTrigger(PLAY);
		} 

		if(_audioSource.clip != null)
		{
			_audioSource.Play();
		}

		if(_particles != null)
		{
			_particles.Play();
		}
	}

}
