using UnityEngine;
namespace QFramework.Example6
{
    public class AchievementSystem : AbstractSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<CounterAppModel>();
            this.RegisterEvent<CountChangeEvent>( e =>
            {
                if ( model.Count == 10 )
                {
                    Debug.Log( "點擊達人成就達成" );
                }
                else if ( model.Count == 20 ) 
                {
                    Debug.Log("點擊專家成就達成");
                }
                else if ( model.Count == -10 )
                {
                    Debug.Log( "點擊菜鳥成就達成" );
                }
            } );
        }
    }
}
