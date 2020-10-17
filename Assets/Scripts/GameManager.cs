using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LevelLoader _levelLoader;
    public string nextLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("Change scene!");
        ChangeLevel();
    }

    public void ChangeLevel()
    {
        _levelLoader.ChageScene(nextLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
