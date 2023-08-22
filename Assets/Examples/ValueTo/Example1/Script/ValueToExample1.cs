using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ValueToExample1 : MonoBehaviour
{
    public TextMeshProUGUI valueText;
    public InputField timeInput;
    public InputField startValueInput;
    public InputField endValueInput;
    public Button playButton;
    private void OnEnable()
    {
        playButton.onClick.RemoveAllListeners();
        playButton.onClick.AddListener(()=> 
        {
            float startValue = float.Parse( startValueInput.text);
            float endValue = float.Parse(endValueInput.text);
            float time = float.Parse(timeInput.text);
            iTween.ValueTo(gameObject, iTween.Hash("from", startValue, "to", endValue, "onupdate", "OnUpdateValue", "time", time));
        });
       
    }
    void OnUpdateValue(float value)
    {
        valueText.text = value.ToString();
    }
}
