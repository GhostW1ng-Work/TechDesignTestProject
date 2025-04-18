using UnityEngine;

public class PauseMenuOpener : MonoBehaviour
{
	[SerializeField] private KeyCode _pauseKey;
	[SerializeField] private CanvasGroup _pauseMenu;

	private bool _isPaused = false;

	private void Start()
	{
		ChangeActivity();
	}

	private void Update()
	{
		if (Input.GetKeyDown(_pauseKey))
		{
			_isPaused = !_isPaused;
			ChangeActivity();
		}
	}

	private void ChangeActivity()
	{
		if (_isPaused)
		{
			_pauseMenu.alpha = 1;
			_pauseMenu.blocksRaycasts = true;
			_pauseMenu.interactable = true;
		}
		else
		{
			_pauseMenu.alpha = 0;
			_pauseMenu.blocksRaycasts = false;
			_pauseMenu.interactable = false;
		}
	}
}
