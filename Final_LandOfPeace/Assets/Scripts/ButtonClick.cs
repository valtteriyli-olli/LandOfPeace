using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
    }

}
