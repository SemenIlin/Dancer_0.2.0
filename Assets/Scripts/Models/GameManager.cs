using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ModelController modelController;
    [SerializeField] private ButtonController buttonController;

    [SerializeField] private AnimationSpeenController speenController;
    private void Start()
    {
        modelController.Init();
        buttonController.Init();
        

        for (int i = 0; i < modelController.Dansers.Count; i++)
        {
            buttonController.Selectors[i].Init(modelController.Dansers);
        }

        speenController.Init(modelController.Dansers);

    }
}
