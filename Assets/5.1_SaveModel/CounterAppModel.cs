using UnityEngine;

namespace QFramework.Example5_1
{
    public class CounterAppModel : AbstractModel
    {
        private int mCount = 0;

        public int Count
        {
            get => mCount;
            set
            {
                if ( mCount != value )
                {
                    mCount = value;
                    PlayerPrefs.SetInt( nameof( Count ), value );
                }
            }
        }
        protected override void OnInit()
        {
            Count = PlayerPrefs.GetInt( nameof( Count ), 0 );
        }
    }
}
