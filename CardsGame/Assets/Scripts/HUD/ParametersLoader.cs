using UnityEngine;
using TMPro;
public class ParametersLoader : MonoBehaviour
{
    public Transform parameterPrefab;
    public Transform container;
    void Start()
    {
        CreateParameters();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateParameters()
    {
        foreach(var parameter in DataManager.Instance.difficultyLevel.parameters)
        {
            Transform parameterObject = Instantiate(parameterPrefab, container);

            parameterObject.Find("nameText").GetComponent<TMP_Text>().text = parameter.name;
            parameterObject.Find("minmaxText").GetComponent<TMP_Text>().text = $"{parameter.min} - {parameter.max}";
            parameterObject.Find("scoreText").GetComponent<TMP_Text>().text = "0";
            parameterObject.Find("infoText").GetComponent<TMP_Text>().text = "Wszytsko jest super";
        }

    }
}
