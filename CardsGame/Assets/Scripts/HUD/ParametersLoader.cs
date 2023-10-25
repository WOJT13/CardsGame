using UnityEngine;
public class ParametersLoader : MonoBehaviour
{
    public GameObject parameterPrefab;
    public Transform container;
    void Start()
    {
        //CreateParameters();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void CreateParameters()
    {
        foreach(var parameter in DataManager.Instance.difficultyLevel.parameters)
        {
            GameObject parameterObject = Instantiate(parameterPrefab, container);
            parameterObject.GetComponentInChildren<TMP_Text>().text
        }

    }*/
}
