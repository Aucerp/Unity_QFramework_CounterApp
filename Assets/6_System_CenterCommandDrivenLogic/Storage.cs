using UnityEngine;
namespace QFramework.Example6
{
    public class Storage : IUtility
    {
        public void SaveInt( string key, int value )
        {
            PlayerPrefs.SetInt( key, value );
        }

        public int LoadInt( string key, int defaultValue = 0 )
        {
            return PlayerPrefs.GetInt( key, defaultValue );
        }
    }
}