using UnityEngine;
namespace QFramework.Example7
{
    public class AchievementSystem : AbstractSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<CounterAppModel>();

            //this.RegisterEvent<CountChangeEvent>( e =>
            model.Count.Register( count =>
            {
                if ( count == 10 )
                {
                    Debug.Log( "點擊達人成就達成" );
                }
                else if ( count == 20 ) 
                {
                    Debug.Log("點擊專家成就達成");
                }
                else if ( count == -10 )
                {
                    Debug.Log( "點擊菜鳥成就達成" );
                }
            } );
        }
    }
}
