using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

[RequireComponent(typeof(Button), typeof(Image))]
public class LanguageSwitchButton : MonoBehaviour
{
	private const string RU = "ru";
	private const string EN = "en";

	[SerializeField] private Sprite _enImage;
	[SerializeField] private Sprite _ruImage;

	private Image _image;
	private Button _button;
	private bool _isEnglish = true;

	private void Awake()
	{
		_image = GetComponent<Image>();
		_button = GetComponent<Button>();
	}

	private void Start()
	{
		if (_isEnglish)
			SwitchLanguage(EN);
		else
			SwitchLanguage(RU);
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(OnClick);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(OnClick);
	}

	private void OnClick()
	{
		_isEnglish = !_isEnglish;
		if (_isEnglish)
			SwitchLanguage(EN);
		else
			SwitchLanguage(RU);
	}

	private void SwitchLanguage(string code)
	{
		if(_isEnglish)
			_image.sprite = _enImage;
		else
			_image.sprite = _ruImage;

		LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales.Find(locale => locale.Identifier.Code == code);
		print(LocalizationSettings.SelectedLocale);
	}
}
